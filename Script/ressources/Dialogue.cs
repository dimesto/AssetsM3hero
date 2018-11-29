using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue", order = 1)]
public class Dialogue : ScriptableObject
{
    public static string Curent
    {
        get
        {
            return PlayerPrefs.GetString("curentDial", "intro");
        }
        set
        {
            PlayerPrefs.SetString("curentDial", value);
        }
    }
    public static Dialogue dialogue
    {
        get
        {
            return Resources.Load<Dialogue>("Dialogue/"+Curent);
        }
    }

    public Sprite icone;
    
    public string group;
    public string key;

    public string next;
}
