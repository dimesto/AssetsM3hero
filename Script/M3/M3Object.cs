using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3Object : MonoBehaviour
{


    public M3Point previous;
    public M3Point Linked;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Linked)
		if(Vector3.Distance(transform.position, Linked.transform.position) > 0.2f)
        {
            transform.position += (Linked.transform.position - transform.position).normalized * Time.deltaTime * 5.0f;
        }
        else
        {
            transform.position = Linked.transform.position;

                if (previous != null)
                    if (previous.Linked == this)
                    {
                        if (Linked.previous != previous)
                            previous.curentSide++;

                        previous.Linked = null;

                    }

                if (Linked.getNext() != null)
                {
                    previous = Linked;
                    Linked = Linked.getNext();
                    Linked.Linked = this;
                }

                
        }
	}
}
