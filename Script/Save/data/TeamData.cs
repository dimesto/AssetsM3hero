using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TeamData
{
    public List<TeammateData> mates = new List<TeammateData>();

    public TeamData()
    {
        mates.Add(new TeammateData());
    }
}
