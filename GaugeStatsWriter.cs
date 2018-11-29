using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaugeStatsWriter : MonoBehaviour
{

    public persoDataReceiver perso;
    public StatType stat = StatType.Strengt;
    GaugeUI gauge;

    // Use this for initialization
    void Start()
    {
        gauge = GetComponent<GaugeUI>();

    }

    // Update is called once per frame
    void Update()
    {
        if (stat == StatType.Strengt)
            gauge.value = (float)perso.CurStrengt/(float)perso.Strengt;
        else if (stat == StatType.Stamina)
            gauge.value = (float)perso.CurStamina/(float)perso.Stamina;
        else if (stat == StatType.Charisma)
            gauge.value = (float)perso.CurCharisma/(float)perso.Charisma;
        else if (stat == StatType.Wisdom)
            gauge.value = (float)perso.CurWisdom/(float)perso.Wisdom;
        else if (stat == StatType.Mind)
            gauge.value = (float)perso.CurMind/(float)perso.Mind;
        else if (stat == StatType.Agility)
            gauge.value = (float)perso.CurAgility/(float)perso.Agility;

    }
}
public enum StatType
{
    Strengt, Stamina, Charisma, Wisdom, Mind, Agility
}
