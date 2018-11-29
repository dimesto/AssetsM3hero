using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLiveWriter : MonoBehaviour {

    public MonsterInfo info;
    GaugeUI gauge;
    // Use this for initialization
    void Start () {

        gauge = GetComponent<GaugeUI>();
    }
	
	// Update is called once per frame
	void Update () {
        gauge.value = info.LifePourcent;
		
	}
}
