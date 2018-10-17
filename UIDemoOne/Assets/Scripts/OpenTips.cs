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
        TipsManeger.Instance.targetLabel = gameObject.GetComponentInChildren<UILabel>();
        TipsManeger.Instance.DestroyEvent += DestroyOnClick;
     }
    public void DestroyOnClick()
    {
        gameObject.SetActive(false);
    }

}