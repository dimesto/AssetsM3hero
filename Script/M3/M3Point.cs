using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3Point : MonoBehaviour {

    public M3Object Linked;

    public M3Point previous;
    public M3Point next;

    public int curentSide = 0;
    public List<M3Point> sideNext;

    // Update is called once per frame
    public M3Point getNext () {
        if(next ==  null)
            return null;

        if (next.Linked != null)
            return getNextSide();
        else
            return next;
	}
    public M3Point getNextSide()
    {
        if(sideNext.Count > 0)
        {
            if (curentSide >= sideNext.Count) curentSide = 0;

            if(sideNext[curentSide].Linked == null)
            return sideNext[curentSide];

        }
        return null;
    }

    // Use this for initialization
    void Start ()
    {
        if (next != null) next.previous = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
