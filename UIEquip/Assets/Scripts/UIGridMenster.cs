using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGridMenster : MonoBehaviour
{
    public int gridCount;  //格子数量

    private Object geziPerfab;  //格子预制件

    public Transform bgTrans;   //背景

    private Object itemPerfab;  //物品预制件

    private List<Transform> gridList;

    private void Start()
    {
        geziPerfab = Resources.Load("Cell");
        itemPerfab = Resources.Load("Equip");
        gridList = new List<Transform>();
        for (int i = 0; i < gridCount; i++)
        {
            GameObject go = Instantiate(geziPerfab) as GameObject;  //实例化格子到场景中
            go.transform.SetParent(bgTrans);    //设置父物体
            go.transform.localScale = Vector3.one;  //将格子大小归一
            gridList.Add(go.transform);   //将格子进行存储
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))    //按下W键
        {
            //获取第一个空的格子
            Transform grid = GetEmptyGrid();
            if (grid == null)   //如果Grid为空，就说明没有空格子了
                return;

            GameObject go = Instantiate(itemPerfab, grid) as GameObject;  //创建物品游戏物体
            UISprite sprite = go.GetComponent<UISprite>();
            sprite.spriteName = sprite.atlas.spriteList[Random.Range(0, sprite.atlas.spriteList.Count)].name;
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
        }
    }

    private Transform GetEmptyGrid()
    {
        //int index = 0;
        //do
        //{
        //    index = Random.Range(0, gridList.Count);
        //} while (gridList[index].childCount > 0);
        //if (gridList[index].childCount <= 0)
        //{
        //    return gridList[index];
        //}
        for (int i = 0; i < gridList.Count; i++)
        {
            if (gridList[i].childCount <= 0)
            {
                return gridList[i];
            }
        }
        return null;
    }

    #region 自己代码

    //public GameObject grid;
    //public GameObject[] cells;
    //private List<Transform> celllist;
    //private GameObject eauip;
    //private GameObject targetCell;

    //private void Start()
    //{
    //    targetCell = Resources.Load<GameObject>("Cell");
    //    eauip = Resources.Load<GameObject>("Equip");
    //    cells = new GameObject[9];
    //    for (int i = 0; i < cells.Length; i++)
    //    {
    //        GameObject go = Instantiate<GameObject>(targetCell, grid.transform);
    //        go.transform.localScale = Vector3.zero;
    //        celllist.Add(go.transform);
    //    }
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Transform gridEmoty = GetGridEmoty();
    //        if (gridEmoty == null)
    //        {
    //            return;
    //        }
    //        Instantiate(eauip, gridEmoty);
    //        eauip.transform.localPosition = Vector3.zero;//归零坐标
    //        eauip.transform.localScale = Vector3.one;//大小归一
    //    }
    //}

    //public Transform GetGridEmoty()
    //{
    //    int index = Random.Range(0, celllist.Count);
    //    if (celllist[index].transform.childCount == 0)
    //    {
    //        return celllist[index];
    //    }
    //    return null;
    //}

    #endregion 自己代码
}