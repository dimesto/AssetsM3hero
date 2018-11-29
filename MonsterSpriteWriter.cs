using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterSpriteWriter : MonoBehaviour
{

    public MonsterInfo info;
    Image img;


	// Use this for initialization
	void Start () {

        img = this.GetComponent<Image>();
        img.sprite = info.Texture;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
