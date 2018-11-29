using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameInfo
{
    public float gametime = 0.0f;

    public string MapName = "heroChambre";
    public float MapX = 0.0f;
    public float MapY = 0.0f;


    public List<LogicalLever> logicalLever = new List<LogicalLever>();

    public bool getLogic(string name, bool defaultValue)
    {
        bool res = defaultValue;
        bool isSet = false;

        for (int i = 0; logicalLever.Count > i; i++)
        {
            if (logicalLever[i].name == name)
            {
                res = logicalLever[i].value;
                isSet = true;
            }
        }
        if(!isSet)
        {
            logicalLever.Add(new LogicalLever(name, defaultValue));
        }

        return res;
    }
    public void SetLogic(string name, bool value)
    {
        bool isSet = false;

        for (int i = 0; logicalLever.Count > i; i++)
        {
            if (logicalLever[i].name == name)
            {
                logicalLever[i].value = value;
                isSet = true;
            }
        }
        if (!isSet)
        {
            logicalLever.Add(new LogicalLever(name, value));
        }
    }

}
[System.Serializable]
public class LogicalLever
{
    public string name;
    public bool value;

    public LogicalLever(string n , bool v)
    {
        name = n;
        value = v;
    }
}