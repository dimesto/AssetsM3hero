using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomerWriter : MonoBehaviour {
    Text txt;

    public Timer time;
    // Use this for initialization
    void Start ()
    {
        txt = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        txt.text = time.value.ToString("0.00") + "s  ";

    }
}
