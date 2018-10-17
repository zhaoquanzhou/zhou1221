using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnchor : MonoBehaviour
{
    //以左上角为例
    public Camera cameraUI;

    [ExecuteInEditMode]
    private void Update()
    {
        //拿到左上角屏幕的屏幕坐标
        Vector3 pos = new Vector3(Screen.width, Screen.height);

        transform.position = cameraUI.ScreenToWorldPoint(pos);//屏幕左上角坐标转射界坐标赋值给自己;
    }
}