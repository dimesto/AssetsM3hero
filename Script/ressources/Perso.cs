using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Perso", menuName = "Perso", order = 1)]
public class Perso : ScriptableObject
{

    public static Perso find(string file)
    {
        return Resources.Load<Perso>("perso/" + file);
    }

    public string Name;

    public string job;
    public Job jobdata
    {
        get
        {
            return Job.find(job);
        }
    }
    public Sprite Face;

    public int Life;

}