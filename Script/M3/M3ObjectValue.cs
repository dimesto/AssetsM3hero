using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3ObjectValue : MonoBehaviour {

    public int Type;
    public int value;

    public GameObject prefabDestroySpawn;

    public static M3Object select1 = null;
    public static M3Object select2 = null;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
        M3Object obj = GetComponent<M3Object>();
        M3PointNear nearPoint = obj.Linked.GetComponent<M3PointNear>();

        if (value >= 3)
        {
            if(prefabDestroySpawn)
            {
                GameObject go = GameObject.Instantiate(prefabDestroySpawn,transform.position,transform.rotation);
            }
            obj.Linked = null;
            Destroy(this.gameObject);
        }


        if (nearPoint != null)
        value = nearPoint.getValue();



        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == this.gameObject)
            {
                OnMouseClick();
            }
        }

        if(select1 == obj && select2 != null)
        {
            M3Point temp = null;

            temp = select2.previous;
            select2.previous = select1.previous;
            select1.previous = temp;

            select1.Linked.Linked = select2;
            select2.Linked.Linked = select1;

            temp = select2.Linked;
            select2.Linked = select1.Linked;
            select1.Linked = temp;




            select1 = null;
            select2 = null;

            GameStat.curent = GameStat.curent.Replace("Fight.Focus", "Fight.FocusMove");
        }

    }

    void OnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            select1 = GetComponent<M3Object>();
        }
        if(select1 != null)
        if (Input.GetMouseButtonUp(0))
        {
                if (Vector3.Distance(transform.position, select1.transform.position) < 1.2f)
                {
                    select2 = GetComponent<M3Object>();
                }
        }
    }
}
