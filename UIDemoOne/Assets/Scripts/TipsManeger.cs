using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsManeger : MonoBehaviour
{
    #region 单例模式

    private static TipsManeger instance;

    public static TipsManeger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(TipsManeger)) as TipsManeger;
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    instance = obj.AddComponent<TipsManeger>();
                }
            }
            return instance;
        }
    }

    #endregion 单例模式

    public delegate void DestroyGameobject();

    public GameObject targetBuotton;

    public UILabel targetLabel;
    private UILabel label;

    private void Start()
    {
        label = gameObject.GetComponentInChildren<UILabel>();
        targetLabel = targetLabel.GetComponentInChildren<UILabel>();
    }

    private void Update()
    {
        label.text = targetLabel.text;
    }

    public void OnClickSure()
    {
        targetBuotton.SetActive(false);
    }

    public void OnClickCancel()
    {
        gameObject.SetActive(false);
    }
}