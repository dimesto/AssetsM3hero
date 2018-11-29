using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUI : MonoBehaviour
{
    public static SelectUI lastSelect = null;

    public bool Selected = false;

    public SelectUI Up;
    public SelectUI Down;
    public SelectUI Left;
    public SelectUI Right;

    public float keyDelay;
    float keyTime;

    // Use this for initialization
    void Start()
    {
        if(Selected) lastSelect = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Selected)
        {
            if (keyDelay < keyTime)
            {
                keyTime = 0;
                if (Input.GetAxis("Vertical") > 0 && Up != null)
                {
                    OnUnselect();
                    Up.OnSelect();
                }
                else if (Input.GetAxis("Vertical") < 0 && Down != null)
                {
                    OnUnselect();
                    Down.OnSelect();
                }
                else if (Input.GetAxis("Horizontal") > 0 && Right != null)
                {
                    OnUnselect();
                    Right.OnSelect();
                }
                else if (Input.GetAxis("Horizontal") < 0 && Left != null)
                {
                    OnUnselect();
                    Left.OnSelect();
                }
            }
            else
            {
                keyTime += Time.deltaTime;
            }

        }
        else
        {
            if(lastSelect != null)
            if (Input.anyKey && !lastSelect.Selected)
            {
                lastSelect.OnSelect();
            }
        }
    }
    void OnOverEnter()
    {
        OnSelect();
    }
    void OnOverExit()
    {
        OnUnselect();
    }

    public void OnSelect()
    {
        lastSelect = this;
        Selected = true;
    }
    public void OnUnselect()
    {
        Selected = false;
    }
}
