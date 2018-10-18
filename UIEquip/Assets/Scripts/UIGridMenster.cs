using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGridMenster : MonoBehaviour
{
    public GameObject grid;
    private GameObject[] cell;
    private GameObject eauip;
    private GameObject targetCell;

    private void Start()
    {
        cell = GameObject.FindGameObjectsWithTag("Cell");
        eauip = Resources.Load<GameObject>("Equip");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnClicKCell();
        }
    }

    public void OnClicKCell()
    {
        int index = Random.Range(0, cell.Length);
        if (cell[index].transform.childCount != 0)
        {
            index = Random.Range(0, cell.Length);
        }
        if (cell[index].transform.childCount == 0)
        {
            Instantiate(eauip, cell[index].transform);
            eauip.transform.SetParent(cell[index].transform);
            eauip.transform.localPosition = Vector3.zero;//归零坐标
            eauip.transform.localScale = Vector3.one;
        }
    }
}