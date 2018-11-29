using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSelect : MonoBehaviour
{

    public List<SelectUI> points = new List<SelectUI>();
    public SelectUI pointSelect = null;

    public Vector2 offset = Vector2.zero;

    public float speed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (SelectUI.lastSelect != null)
            if (points.Contains(SelectUI.lastSelect))
                pointSelect = SelectUI.lastSelect;

        if(pointSelect != null)
            this.transform.position = Vector3.Lerp(this.transform.position, pointSelect.transform.position + (Vector3)offset, Time.deltaTime * speed);
    }
}
