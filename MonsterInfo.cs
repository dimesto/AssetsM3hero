using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInfo : MonoBehaviour
{
    public int idMonster = -1;

    public string monsterString
    {
        get
        {
            return Fight.CurFight.monster[idMonster];
        }
    }
    public Monster monsterObj
    {
        get
        {
            return Monster.find(monsterString);
        }
    }
    public Sprite Texture
    {
        get
        {
            return monsterObj.fightSprite;
        }
    }
    public int LifeMax
    {
        get
        {
            return monsterObj.life;
        }
    }
    int life = -1;
    public int Life
    {
        get
        {
            if (life < 0) life = LifeMax;

            return life;
        }
        set
        {
            if (value == 0) GameObject.Destroy(this.gameObject);
            life = value;
        }
    }
    public float LifePourcent
    {
        get
        {
            //Debug.Log(Life);
            //Debug.Log(LifeMax);
            return ((float)Life / (float)LifeMax);
        }
    }
    public string Name
    {
        get
        {
            return lang.findLang(PlayerPrefs.GetString("lang","Eng"),"Monster").findText(monsterObj.name).value;
        }
    }
    public List<MonsterSkill> skills
    {
        get
        {
            return monsterObj.skill;
        }
    }
    public int curskills = -1;
    public string curSkillname
    {
        get
        {
            if (curskills == -1) return "";
            return skills[curskills].Skill;
        }
    }
    public float curSkillTime
    {
        get
        {
            if (curskills == -1) return 0.0f;
            return skills[curskills].time;
        }
    }
    public int curSkillDomage
    {
        get
        {
            if (curskills == -1) return 0;
            return skills[curskills].domage;
        }
    }

}
