using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class curStatsWriter : MonoBehaviour
{
    public persoDataReceiver perso;
    public StatType stat = StatType.Strengt;

    Text txt;
    // Use this for initialization
    void Start () {

        txt = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (stat == StatType.Strengt)
            txt.text = perso.CurStrengt.ToString();
        else if (stat == StatType.Stamina)
            txt.text = perso.CurStamina.ToString();
        else if (stat == StatType.Charisma)
            txt.text = perso.CurCharisma.ToString();
        else if (stat == StatType.Wisdom)
            txt.text = perso.CurWisdom.ToString();
        else if (stat == StatType.Mind)
            txt.text = perso.CurMind.ToString();
        else if (stat == StatType.Agility)
            txt.text = perso.CurAgility.ToString();
    }
}
