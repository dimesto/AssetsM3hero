using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SkillStatWriter : MonoBehaviour
{

    public SkillInfo info;
    public StatType stat = StatType.Strengt;

    Text txt;
    // Use this for initialization
    void Start ()
    {
        txt = this.GetComponent<Text>();
        if (stat == StatType.Strengt)
            txt.text = info.Strenght.ToString();
        else if (stat == StatType.Stamina)
            txt.text = info.Stamina.ToString();
        else if (stat == StatType.Charisma)
            txt.text = info.Charisma.ToString();
        else if (stat == StatType.Wisdom)
            txt.text = info.Wisdom.ToString();
        else if (stat == StatType.Mind)
            txt.text = info.Mind.ToString();
        else if (stat == StatType.Agility)
            txt.text = info.Agility.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
