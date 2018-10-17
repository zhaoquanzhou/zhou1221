using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUICamera : MonoBehaviour
{
    private Camera cam;//摄像机组件
    public LayerMask eventLayers;//层

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, 500, eventLayers))
            {
                //射线碰到物体
                hitInfo.collider.SendMessage("OnClick");
            }
        }
    }
}