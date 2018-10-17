using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowPlayer : MonoBehaviour
{
    //跟随目标
    public Transform taregt;

    public Vector3 offset;

    //主摄像机
    public Camera cameraMain;

    //UI摄像机
    public Camera cameraUI;

    private void Update()
    {
        //拿到当目标前位置
        Vector3 pos = taregt.position + offset;
        //转成屏幕坐标
        pos = cameraMain.WorldToScreenPoint(pos);
        //用UI摄像机转成射界坐标
        pos = cameraUI.ScreenToWorldPoint(pos);
        pos.z = 0;
        //赋值给UI
        transform.position = pos;
    }
}