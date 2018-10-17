using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnBtnClick(GameObject go)
    {
        Debug.Log(go.name);
        TipsManager.Instance.InitUI(go.name.Split('_')[0], () => Destroy(go), null);
    }
}
