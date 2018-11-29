using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Monster", order = 1)]
public class Monster : ScriptableObject
{
    public Sprite fightSprite;

    public string name;

    public int life;

    public List<MonsterSkill> skill = new List<MonsterSkill>();

    public static Monster find(string file)
    {
        return Resources.Load<Monster>("monster/" + file);
    }
}

[System.Serializable]
public class MonsterSkill
{
    public string Skill;
    public float time;
    public int domage;
}