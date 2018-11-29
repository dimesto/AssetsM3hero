using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class TextLang : MonoBehaviour {

    Text txt;

    public string group;
    public string key;

	// Use this for initialization
	void Start () {
        txt = this.GetComponent<Text>();

        txt.text = lang.findLang(PlayerPrefs.GetString("lang", "Eng"),group).findText(key).value;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
