using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : UIDragDropItem
{
    //开始拖拽
    protected override void OnDragDropStart()
    {
        base.OnDragDropStart();
        //修改UI的深度值
        GetComponent<UISprite>().depth += 20;
    }

    //拖拽释放
    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        Debug.Log(surface.name);
        //拖拽到格子上
        if (surface.tag == "")
        {
            if (surface.transform.childCount > 0)//有子物体,与子物体交换父物体
            {
                Transform child = surface.transform.GetChild(0);
                child.SetParent(transform.parent);
                child.transform.localPosition = Vector3.zero;//初始化位置
                child.transform.localScale = Vector3.one;//初始化大小
            }
            transform.SetParent(surface.transform);
            transform.localPosition = Vector3.zero;//初始化位置
            transform.localScale = Vector3.one;//初始化大小
        }
        else if (surface.tag == "")//拖拽到装备上
        {
            //交换父物体
            Transform trans = surface.transform.parent;
            surface.transform.SetParent(transform.parent);
            surface.transform.localPosition = Vector3.zero;
            surface.transform.localScale = Vector3.one;
            transform.SetParent(trans);
            transform.localScale = Vector3.one;
            transform.localPosition = Vector3.zero;
        }
        else if (surface.tag == "")
        {
            transform.localPosition = Vector3.zero;//初始化物品位置
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //拖拽结束
    protected override void OnDragEnd()
    {
        base.OnDragEnd();
        //还原深度值
        GetComponent<UISprite>().depth -= 20;
    }
}