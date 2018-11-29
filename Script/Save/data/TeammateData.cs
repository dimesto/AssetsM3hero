using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TeammateData
{

    public string perso = "hero";
    public string name;

    public int level = 1;
    public int XP = 0;

    public int Life = -1;

    public List<string> stuffSlots = new List<string>();

    public TeammateData()
    {
        for (int i = 0; i < 6; i++)
            stuffSlots.Add("");
    }
}
