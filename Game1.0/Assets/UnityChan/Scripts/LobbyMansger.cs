using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMansger : MonoBehaviour
{
    public void OpenBag()
    {
        //清空物品
        UIMansger.Instence.ClearItem();
        //初始化数据到背包数据存储
        UIMansger.Instence.InitUI();
        //调用玩家背包数据并生成装备UI
        UIMansger.Instence.ReadData();
        //打开背包
        UIMansger.Instence.OpenWindow(WindowType.Bag);
        //关闭主界面
        gameObject.SetActive(false);
    }
}