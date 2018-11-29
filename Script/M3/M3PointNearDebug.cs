using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class M3PointNearDebug : MonoBehaviour {

    M3PointNear obj;
    // Use this for initialization
    void Start ()
    {
        obj = GetComponent<M3PointNear>();

    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < obj.nears.Count; i++)
        {
            if (obj.nears[i])
                Debug.DrawLine(transform.position, obj.nears[i].transform.position, Color.cyan);


        }
    }
}
