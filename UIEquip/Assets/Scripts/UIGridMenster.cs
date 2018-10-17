using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGridMenster : MonoBehaviour
{

    public GameObject grid;
    GameObject[] cell;
    GameObject eauip;
    GameObject targetCell;
    void Start()
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
        for (int i = 0; i < cell.Length; i++)
        {

            if (!cell[i].transform.CompareTag("Equip"))
            {
                eauip.transform.SetParent(cell[i].transform);

                Instantiate(eauip,cell[i].transform);
            }
        }
    }
}
