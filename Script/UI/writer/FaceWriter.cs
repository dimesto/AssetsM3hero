using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceWriter : MonoBehaviour {

    public persoDataReceiver perso;

    Image img;
    // Use this for initialization
    void OnEnable()
    {
        img = this.GetComponent<Image>();
        img.sprite = perso.Face;
    }

    // Update is called once per frame
    void Update () {
		
	}

}
