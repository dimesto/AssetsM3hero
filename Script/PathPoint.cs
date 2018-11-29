using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PathPoint : MonoBehaviour {

    public PathPoint next;
	
	// Update is called once per frame
	void Update () {

        if(next != null)
        Debug.DrawLine(transform.position, next.transform.position, Color.blue);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AiMonster ai = collision.GetComponent<AiMonster>();

        if(ai != null)
        {
            ai.NormalTarget = next.gameObject;
        }
    }
}
