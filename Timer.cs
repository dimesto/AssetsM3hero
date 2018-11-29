using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float timeStart;
    public float value;

	// Use this for initialization
	void Start () {
        value = timeStart;

    }
	
	// Update is called once per frame
	void Update () {
        value -= Time.deltaTime;
        if (value < 0) value = 0;

    }
}
