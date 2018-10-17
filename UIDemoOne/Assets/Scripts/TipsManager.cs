using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public delegate void MyDele();

public class TipsManager : MonoBehaviour
{
    private static TipsManager instance;
    public static TipsManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    [SerializeField]    //特性：在Hierarchy面板能够看见并赋值
    UILabel infoLabel;

    Action onSure, onCancle;

    public void InitUI(string info, Action _onSure, Action _onCancle)
    {
        infoLabel.text = "Current Equipment:" + info;
        onSure = _onSure;
        onCancle = _onCancle;
        if (!gameObject.activeSelf)
            gameObject.SetActive(true);
    }

    public void OnSureClick()   //确定
    {
        if (onSure != null)
            onSure();
        gameObject.SetActive(false);
    }

    public void OnCancleClick()  //取消
    {
        if (onCancle != null)
            onCancle();
        gameObject.SetActive(false);
    }
}
