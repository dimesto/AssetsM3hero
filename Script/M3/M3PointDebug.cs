using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class M3PointDebug : MonoBehaviour
{

    M3Point obj;

    // Use this for initialization
    void Start()
    {
        obj = GetComponent<M3Point>();
        gameObject.name = "point(" + transform.localPosition.x + "," + transform.localPosition.y + ")";
    }

    // Update is called once per frame
    void Update()
    {

        if (obj.next)
            Debug.DrawLine(transform.position, obj.next.transform.position, Color.green);

        for(int i = 0; i < obj.sideNext.Count; i++)
        {
            if(i == obj.curentSide)
                Debug.DrawLine(transform.position, obj.sideNext[i].transform.position, Color.yellow);
            else
                Debug.DrawLine(transform.position, obj.sideNext[i].transform.position, Color.red);


        }

    }
}
