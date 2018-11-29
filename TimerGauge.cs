using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerGauge : MonoBehaviour {
    GaugeUI gauge;

    public Timer time;

	// Use this for initialization
	void Start () {
        gauge = GetComponent<GaugeUI>();

    }
	
	// Update is called once per frame
	void Update () {
        gauge.value = 1.0f - (time.value / time.timeStart);

    }
}
