using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgilityWriter : MonoBehaviour
{
    public persoDataReceiver perso;

    Text txt;

    // Use this for initialization
    void OnEnable()
    {
        txt = this.GetComponent<Text>();
        txt.text = perso.Agility.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
