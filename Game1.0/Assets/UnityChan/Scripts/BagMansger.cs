using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagMansger : MonoBehaviour
{
    public void CloseBag()
    {
        //保存物品存储信息;
        UIMansger.Instence.SaveData();
        //打开主界面
        UIMansger.Instence.OpenWindow(WindowType.Lobby);
        //关闭背包界面
        gameObject.SetActive(false);      
        //清空物品
        UIMansger.Instence.ClearItem();
    }   
}