using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Job", menuName = "Job", order = 1)]
public class Job : ScriptableObject
{
    public static Job find(string file)
    {
        return Resources.Load<Job>("job/" + file);
    }

    public string Name;

    public int LifeBase;
    public int LifeEvole;


    public int StrengthBase;
    public int StrengthEvole;

    public int StaminaBase;
    public int StaminaEvole;

    public int CharismaBase;
    public int CharismaEvole;

    public int WisdomBase;
    public int WisdomEvole;

    public int MindBase;
    public int MindEvole;

    public int AgilityBase;
    public int AgilityEvole;

    public List<string> skills = new List<string>();

}

