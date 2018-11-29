using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3PointNear : MonoBehaviour {

    M3Point point;

    public List<M3PointNear> nears;

    public int getValue(int valTest, int direction)
    {
        if (point.Linked != null)
        {
            int val = -1;

            if(point.Linked.transform.position == point.transform.position )
                val = point.Linked.GetComponent<M3ObjectValue>().Type;

            if (val == valTest)
            {
                if (nears[direction] != null)
                    return 1 + nears[direction].getValue(valTest, direction);

                return 1;
            }
        }
        return 0;
    }
    public     int i0 = 0;
    public     int i1 = 0;
    public     int i2 = 0;
    public     int i3 = 0;
    public int getValue()
    {
        int val = point.Linked.GetComponent<M3ObjectValue>().Type;
        
        i0 = getValue(val, 0);
        i1 = getValue(val, 1);
        i2 = getValue(val, 2);
        i3 = getValue(val, 3);


        if (i0 + i2 > i1 + i3)
            return i0 + i2-1;
        else
            return i1 + i3-1;

        return 0;
    }
    // Use this for initialization
    void Start ()
    {
        point = GetComponent<M3Point>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
