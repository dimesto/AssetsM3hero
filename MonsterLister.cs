using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLister : MonoBehaviour
{
    public GameObject prefab;

	// Use this for initialization
	void Start ()
    {
        if (Fight.CurFight == null)
            Fight.CurFight = Fight.find("woodFight");

        for(int i = 0; i < Fight.CurFight.monster.Count; i++)
        {
            GameObject go = GameObject.Instantiate(prefab, transform);
            go.GetComponent<MonsterInfo>().idMonster = i;

        }
		
	}
	
}
