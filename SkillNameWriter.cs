using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SkillNameWriter : MonoBehaviour
{
    public SkillInfo info;
    Text txt;
    // Use this for initialization
    void Start ()
    {
        txt = this.GetComponent<Text>();
        txt.text = info.skillName;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
