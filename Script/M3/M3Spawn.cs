using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3Spawn : MonoBehaviour {

    M3Point obj;

    public List<GameObject> prefab;

    // Use this for initialization
    void Start ()
    {
        obj = GetComponent<M3Point>();

    }
	
	// Update is called once per frame
	void Update () {
        if(prefab.Count > 0)
		if(obj.Linked == null)
        {
            GameObject go = GameObject.Instantiate(prefab[Random.Range(0,prefab.Count)], transform.position, transform.rotation);
            go.transform.parent = this.transform.parent;
            M3Object m3obj = go.GetComponent<M3Object>();
            m3obj.Linked = obj;
            obj.Linked = m3obj;
        }
	}
}
