using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : UIDragDropItem
{
    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        if (surface.name == "Cell")
        {
            transform.SetParent(surface.transform);//把自己设置为子物体
            transform.localPosition = Vector3.zero;//归零坐标
            transform.localScale = Vector3.one;
        }
    }
}