using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMansger : MonoBehaviour
{
    public void OpenBag()
    {
        //清空物品
        UIMansger.Instence.ClearItem();
        //初始化背包物品
        UIMansger.Instence.InitUI();       
        //打开背包
        UIMansger.Instence.OpenWindow(WindowType.Bag);
        //关闭主界面
        gameObject.SetActive(false);
    }
}