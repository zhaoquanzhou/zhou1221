using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    #region 单例模式

    private static PlayerData instence;

    public static PlayerData Instence
    {
        get
        {
            if (instence == null)
            {
                instence = new PlayerData();
            }
            return instence;
        }
    }

    #endregion 单例模式

    public string name;
    public int hp;
    public int mp;
    public int defense;
    public int atk;
    public List<int> equipData = new List<int>();
    public Dictionary<Transform, int> bagData = new Dictionary<Transform, int>();
}