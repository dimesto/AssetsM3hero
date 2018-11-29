using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillCastWriter : MonoBehaviour {

    Text txt;
    public MonsterInfo info;

    // Use this for initialization
    void Start () {
        txt = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(info)
        if(info.curskills != -1)
        txt.text = info.curSkillname;

    }
}
