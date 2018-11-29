using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoLister : MonoBehaviour
{
    public DetailSelect DetailS;

    public GameObject RowPrefab;
    public GameObject CellPrefab;

    public int PersoNum;

    // Use this for initialization
    void Start()
    {
        int cellPerRow = 2;

        PersoNum = PlayerPrefs.GetInt("PersoNum", 1);
        GameObject row; GameObject cell;

        for (int i = 0; i < PersoNum / cellPerRow; i++)
        {
            row = GameObject.Instantiate(RowPrefab, transform);
            for (int j = 0; j < cellPerRow; j++)
            {
                cell = GameObject.Instantiate(CellPrefab, row.transform);
                cell.GetComponent<persoDataReceiver>().IdPerso = j + i * cellPerRow;
                cell.GetComponent<clickSelectPerso>().detail = DetailS;
                cell.GetComponent<clickSelectPerso>().IdPerso = j + i * cellPerRow;
            }
        }

        row = GameObject.Instantiate(RowPrefab, transform);
        for (int j = 0; j < PersoNum % cellPerRow; j++)
        {
            cell = GameObject.Instantiate(CellPrefab, row.transform);
            cell.GetComponent<persoDataReceiver>().IdPerso = j + (PersoNum / cellPerRow) * cellPerRow;
            cell.GetComponent<clickSelectPerso>().detail = DetailS;
            cell.GetComponent<clickSelectPerso>().IdPerso = j + (PersoNum / cellPerRow) * cellPerRow;
        }
        for (int j = 0; j < PersoNum - (PersoNum % cellPerRow); j++)
        {
            cell = new GameObject("empty");
            cell.AddComponent<RectTransform>();
            cell.transform.parent = row.transform;
        }
        if(PersoNum < cellPerRow)
        {
            for (int j = 0; j < cellPerRow - PersoNum ; j++)
            {
                cell = new GameObject("empty");
                cell.AddComponent<RectTransform>();
                cell.transform.parent = row.transform;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
