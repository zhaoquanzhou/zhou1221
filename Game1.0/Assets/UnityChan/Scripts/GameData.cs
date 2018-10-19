using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameData
{
    #region 单例模式

    private static GameData instence;

    public static GameData Instence
    {
        get
        {
            if (instence == null)
            {
                instence = new GameData();
            }
            return instence;
        }
    }

    #endregion 单例模式

    public string jsonFlie;
    public AllEquip allEquip;

    public GameData()
    {
        jsonFlie = File.ReadAllText(Application.dataPath + @"\Resources\Equipment.json");
        AllEquip allEquip = JsonUtility.FromJson<AllEquip>(jsonFlie);
        foreach (var item in allEquip.items)
        {
            Debug.Log(item.name);
        }
    }
}

[System.Serializable]
public class AllEquip
{
    public Item[] items;
}

[System.Serializable]
public class Item
{
    public int id;
    public int type;
    public string name;
    public int hp;
    public int defense;
    public int atk;
    public string describe;
    public string sprite_Name;
}