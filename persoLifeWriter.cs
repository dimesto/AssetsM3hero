using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persoLifeWriter : MonoBehaviour {

    GaugeUI gauge;
    public persoDataReceiver perso;

	// Use this for initialization
	void Start () {
        gauge = this.GetComponent<GaugeUI>();

    }
	
	// Update is called once per frame
	void Update () {

        gauge.value = (float)perso.life /  (float)perso.lifeMax;

    }
}
