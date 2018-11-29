using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSelectPerso : MonoBehaviour
{
    public int IdPerso;
    public DetailSelect detail;

    void OnClickUp()
    {
        detail.idDetail = IdPerso;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
