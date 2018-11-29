using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLogic : MonoBehaviour {

	public static List<string> monsterFight = new List<string>();
	
	public string nameMonster;
	
	// Use this for initialization
	void Start () {
		if(monsterFight.Contains(nameMonster))
			GameObject.Destroy(this.gameObject);
	}
	
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			monsterFight.Add(nameMonster);
        }
    }
}
