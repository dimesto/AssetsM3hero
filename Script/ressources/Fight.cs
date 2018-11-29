using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fight", menuName = "Fight", order = 1)]
public class Fight : ScriptableObject
{
    public List<string> monster = new List<string>();
    public Sprite background;

    public static Fight CurFight;

    public static Fight find(string file)
    {
        return Resources.Load<Fight>("fight/" + file);
    }
}
