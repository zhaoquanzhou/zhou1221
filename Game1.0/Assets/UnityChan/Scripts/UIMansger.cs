using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WindowType//界面枚举
{
    Lobby,
    Bag
}

public class UIMansger : MonoBehaviour
{
    #region 单例模式

    private static UIMansger instence;

    public static UIMansger Instence
    {
        get
        {
            return instence;
        }
    }

    private void Awake()
    {
        instence = this;
    }

    #endregion 单例模式

    #region 控制界面

    public GameObject lobbyWindow;
    public GameObject bagWindow;

    public GameObject OpenWindow(WindowType type)
    {
        switch (type)
        {
            case WindowType.Lobby:
                lobbyWindow.SetActive(true);
                return lobbyWindow;

            case WindowType.Bag:
                bagWindow.SetActive(true);
                return bagWindow;
        }
        return null;
    }

    #endregion 控制界面

    private void Start()
    {
        gridprefab = Resources.Load<GameObject>("gridcell");
        gridCound = 9;
        gridCell = new Transform[gridCound];
        itemPerfab = Resources.Load<GameObject>("ItemPrefab");
        CreateGrid();//生成格子
    }

    #region 格子操作

    private GameObject gridprefab;
    public Transform gridParent;
    public int gridCound;
    private Transform[] gridCell;

    //生成格子
    public void CreateGrid()
    {
        for (int i = 0; i < gridCound; i++)
        {
            GameObject go = Instantiate(gridprefab, gridParent);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            gridCell[i] = go.transform;
        }
    }

    //寻找空格子
    public Transform GridEmpty()
    {
        ReadData();//初始化背包
        foreach (Transform item in gridCell)
        {
            if (item.childCount == 0)
            {
                return item;//返回空格子
            }
        }
        return null;
    }

    #endregion 格子操作

    #region 物品的生成/清空

    private GameObject itemPerfab;  //物品预制件

    //初始化UI：生成物品
    public void InitUI()
    {
        List<int> itemList = PlayerData.Instence.equipData;

        if (itemList.Count == 0)
        {
            return;//玩家数据里没有装备
        }
        if (PlayerData.Instence.bagData.Count == 0)
        {
            CreateItem(itemList);
            SaveData();//保存到背包数据
        }
        else
        {
            ReadData();//读取背包数据
        }
    }

    //实例化物品
    private void CreateItem(List<int> itemList)
    {
        foreach (var indexEquip in itemList)
        {
            CreateItem(indexEquip);
        }
    }

    private void CreateItem(Dictionary<Transform, int> placeData)
    {
        foreach (var placeGrid in placeData.Keys)
        {
            int indexEquip = placeData[placeGrid];
            GameObject go = Instantiate<GameObject>(itemPerfab, placeGrid);  //创建物品游戏物体
            go.transform.localPosition = Vector3.zero;//初始化与父物体位置相同
            go.transform.localScale = Vector3.one;//初始化物品大小
            UISprite sprite = go.GetComponent<UISprite>();
            sprite.spriteName = GameData.Instence.allEquip.items[indexEquip].sprite_Name;//给装备附加相应的UI
        }
    }

    //实例化一个物品UI
    public void CreateItem(int _indexEquip)
    {
        Transform gridEmpty = GridEmpty();
        int indexEquip = _indexEquip;
        if (gridEmpty == null)
        {
            //如果Grid为空，就说明没有空格子了
            Debug.Log("背包满了");
            return;
        }
        GameObject go = Instantiate<GameObject>(itemPerfab, gridEmpty);  //创建物品游戏物体
        go.transform.localPosition = Vector3.zero;//初始化与父物体位置相同
        go.transform.localScale = Vector3.one;//初始化物品大小
        UISprite sprite = go.GetComponent<UISprite>();
        sprite.spriteName = GameData.Instence.allEquip.items[indexEquip].sprite_Name;//给装备附加相应的UI
    }

    //清空物品
    public void ClearItem()
    {
        foreach (var item in gridCell)
        {
            if (item.childCount == 0)
            {
                return;//物品UI已经销毁
            }
            Destroy(item.GetChild(0).gameObject);
        }
    }

    #endregion 物品的生成/清空

    #region 物品的读取/保存/整理

    //保存背包物品数据
    public void SaveData()
    {
        foreach (var cell in gridCell)
        {
            if (cell.childCount == 0)
            {
                return;//保存时没有装备;
            }
            foreach (Transform item in cell.GetChild(0))
            {
                if (cell.childCount > 0)
                {
                    UISprite itemSprite = item.GetComponent<UISprite>();
                    string spriteName = itemSprite.spriteName;
                    int itemId = 0;
                    foreach (var itemEquip in GameData.Instence.allEquip.items)
                    {
                        if (itemEquip.sprite_Name.Equals(spriteName))
                        {
                            itemId = itemEquip.id;
                        }
                    }
                    PlayerData.Instence.bagData.Add(item.parent, itemId);
                }
            }
        }
    }

    //读取背包物品数据并初始化背包
    public void ReadData()
    {
        //调用背包数据位置初始化
        Dictionary<Transform, int> placeData = PlayerData.Instence.bagData;      
        CreateItem(placeData);//初始化背包数据
    }

    //按攻击力的大小排列数据并整理背包
    public void SortData()
    {
        #region 排序

        Dictionary<Transform, int> placeData = PlayerData.Instence.bagData;
        List<int> itemBagId = new List<int>();//装备数据Id
        for (int i = 0; i < placeData.Count; i++)//读取背包存储数据的攻击力
        {
            foreach (var item in placeData.Keys)
            {
                foreach (var itemEquip in GameData.Instence.allEquip.items)
                {
                    if (itemEquip.id == placeData[item])
                    {
                        itemBagId.Add(itemEquip.atk);
                    }
                }
            }
        }
        for (int i = 0; i < itemBagId.Count - 1; i++)//按攻击力降序排序
        {
            for (int j = i + 1; j < itemBagId.Count; j++)
            {
                if (itemBagId[i].CompareTo(itemBagId[j]) < 0)
                {
                    int temp = itemBagId[i];
                    itemBagId[i] = itemBagId[j];
                    itemBagId[j] = temp;
                }
            }
        }

        #endregion 排序

        #region 清空物品

        ClearItem();

        #endregion 清空物品

        #region 生成排列后的物品

        //生成排列后的物品
        CreateItem(itemBagId);

        #endregion 生成排列后的物品
    }

    //当背包打开时,物品掉落实例化UI并保持背包数据
    public void PresentSaveData(bool _present, int ItemId)
    {
        bool present = _present;
        if (present)
        {
            CreateItem(ItemId);//创建单个UI在背包
            SaveData();//保存数据
        }
    }

    #endregion 物品的读取/保存/整理
}