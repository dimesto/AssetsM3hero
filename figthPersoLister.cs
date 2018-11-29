using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class figthPersoLister : MonoBehaviour {

    public GameObject prefab;
    // Use this for initialization

    void Start ()
    {
        if (Save.team == null) Save.team = new TeamData();
        for (int j = 0; j < Save.team.mates.Count; j++)
        {
            GameObject go = GameObject.Instantiate(prefab, transform);
            go.GetComponent<persoDataReceiver>().IdPerso = j ;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
