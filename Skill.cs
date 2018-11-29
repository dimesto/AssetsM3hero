using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Skill", order = 1)]
public class Skill : ScriptableObject
{
    public string Name;

    public int Domage;

    public int CostStrenght = 0;
    public int CostStamina = 0;
    public int CostCharisma = 0;
    public int CostWisdom = 0;
    public int CostMind = 0;
    public int CostAgility = 0;

    public static Skill find(string file)
    {
        return Resources.Load<Skill>("skill/" + file);
    }
}
