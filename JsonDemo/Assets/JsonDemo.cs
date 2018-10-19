using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonDemo : MonoBehaviour
{
    private string JsonFile;

    private void Start()
    {
        JsonFile = File.ReadAllText(Application.dataPath + @"\Equipment.json");
        ItemData itemData = JsonUtility.FromJson<ItemData>(JsonFile);

        foreach (var data in itemData.items)
        {
            Debug.Log(data.name);
        }
    }

    private void Update()
    {
    }
}

[System.Serializable]
public class ItemData
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