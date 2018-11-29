using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activePauseMenu : MonoBehaviour {

    public bool menuOpen = false;

    public float keyDelay;
    float keyTime;

    Canvas canva;

	// Use this for initialization
	void Start () {
        canva = this.GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (keyDelay < keyTime)
        {
            keyTime = 0;
            if (Input.GetKey(KeyCode.Escape))
            {
                menuOpen = !menuOpen;
            }

            canva.enabled = menuOpen;
        }
        else
        {
            keyTime += Time.deltaTime;
        }


    }
}
