using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTips : MonoBehaviour
{
    public GameObject openTips;
    public GameObject targetBuotton;

    private void Start()
    {
    }

    public void OnClickButton()
    {
        openTips.SetActive(true);
        TipsManeger.Instance.targetBuotton = targetBuotton;
    }
}