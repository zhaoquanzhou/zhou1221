using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridControl : MonoBehaviour
{
    private GameObject gridprefab;
    public int gridCound;
    private Transform[] gridCell;

    private void Start()
    {
        gridprefab = Resources.Load<GameObject>("gridcell");
        gridCound = 9;
        gridCell = new Transform[gridCound];
        for (int i = 0; i < gridCound; i++)
        {
            GameObject go = Instantiate(gridprefab, transform);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            gridCell[i] = go.transform;
        }
    }
}