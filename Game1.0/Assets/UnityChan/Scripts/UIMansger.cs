using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMansger : MonoBehaviour
{
    private static UIMansger instence;

    public static UIMansger Instence1
    {
        get
        {
            return instence;
        }
    }

    private void Awake()
    {
        instence = this;
    }
}