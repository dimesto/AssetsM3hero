using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveNameWriter : MonoBehaviour {

    public SaveInfo info;

    Text txt;

    // Use this for initialization
    void OnEnable() {

        txt =  this.GetComponent<Text>();
        txt.text = info.name;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
