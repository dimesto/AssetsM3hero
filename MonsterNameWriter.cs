using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterNameWriter : MonoBehaviour {

    public MonsterInfo info;
    Text txt;

	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
        txt.text = info.Name;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
