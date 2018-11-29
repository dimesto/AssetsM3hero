using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGroup : MonoBehaviour
{

    public List<GameObject> panels = new List<GameObject>();

	public void setID(int i)
    {
		foreach(GameObject go in panels)
        {
            go.SetActive(false);
        }

        panels[i].SetActive(true);

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
