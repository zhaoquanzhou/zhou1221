using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : UIDragDropItem
{
    //拖拽开始
    protected override void OnDragDropStart()
    {
        base.OnDragDropStart();
        //修改图片的深度值
        GetComponent<UISprite>().depth += 10;
    }

    //拖拽释放的那帧

    //拖拽释放的那帧
    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        Debug.Log(surface.name);
        //如果拖到格子上
        if (surface.tag == "Cell")
        {
            if (surface.transform.childCount > 0)   //说明格子有子物体
            {
                //获取格子的子物体
                Transform child = surface.transform.GetChild(0);
                child.SetParent(transform.parent);
                child.transform.localPosition = Vector3.zero;
                child.transform.localScale = Vector3.one;
            }
            transform.SetParent(surface.transform);
            transform.localScale = Vector3.one;
            transform.localPosition = Vector3.zero;
        }
        else if (surface.tag == "Equip")//如果拖到装备上
        {
            //交换父物体
            //获取打到的装备的父物体
            Transform trans = surface.transform.parent;
            surface.transform.SetParent(transform.parent);
            surface.transform.localPosition = Vector3.zero;
            surface.transform.localScale = Vector3.one;
            transform.SetParent(trans);
            transform.localScale = Vector3.one;
            transform.localPosition = Vector3.zero;
        }
        else if (surface.tag == "Interface")//如果拖到背包上
        {
            transform.localPosition = Vector3.zero;
        }
        else//拖到背包外
        {
            Destroy(gameObject);
        }
    }

    //拖拽结束
    protected override void OnDragEnd()
    {
        base.OnDragEnd();
        //把深度值还原
        GetComponent<UISprite>().depth -= 10;
    }
}