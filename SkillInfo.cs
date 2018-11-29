using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillInfo : MonoBehaviour {

    public int idPerso;
    public int idSkill;

                string strSkill = "";

    // Use this for initialization
    void Start()
    {
        persoDataReceiver[] persos = GameObject.FindObjectsOfType<persoDataReceiver>();
        for (int i = 0; i < persos.Length; i++)
        {
            if (persos[i].IdPerso == idPerso)
            {
                string jobstr = persos[i].Job;
                Job job = Job.find(jobstr);
                strSkill = job.skills[idSkill];
            }
        }
    }

    public Skill skillObj
    {
        get
        {
            return Skill.find(strSkill);
        }
    }
    public string skillName
    {
        get
        {
            return lang.findLang(PlayerPrefs.GetString("lang","Eng"),"skill").findText(skillObj.Name).value;
        }
    }
    public int Strenght
    {
        get
        {
            return skillObj.CostStrenght;
        }
    }
    public int Stamina
    {
        get
        {
            return skillObj.CostStamina;
        }
    }
    public int Charisma
    {
        get
        {
            return skillObj.CostCharisma;
        }
    }
    public int Wisdom
    {
        get
        {
            return skillObj.CostWisdom;
        }
    }
    public int Mind
    {
        get
        {
            return skillObj.CostMind;
        }
    }
    public int Agility
    {
        get
        {
            return skillObj.CostAgility;
        }
    }


	
}
