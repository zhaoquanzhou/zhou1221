using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpirte : MonoBehaviour
{
    public UISprite spriteTarget;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 200, 100), "随机"))
        {
            spriteTarget.spriteName = spriteTarget.atlas.spriteList[Random.Range(0, spriteTarget.atlas.spriteList.Count)].name;
        }
    }
}