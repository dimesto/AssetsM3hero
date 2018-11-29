using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemQteWriter : MonoBehaviour {
    public ItemStackData data;
    Text txt;
    // Use this for initialization
    void OnEnable() {
        txt = this.GetComponent<Text>();
        txt.text = data.qte.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
