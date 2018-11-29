using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fightManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        persoDataReceiver[] persos = GameObject.FindObjectsOfType<persoDataReceiver>();
        MonsterInfo[] Monsters = GameObject.FindObjectsOfType<MonsterInfo>();

        bool gameOver = true;
        bool win = false;

        foreach(persoDataReceiver perso in persos)
        {
            if (perso.life > 0)
                gameOver = false;
        }
        if (Monsters.Length == 0)
            win = true;

        if (gameOver)
            SceneManager.LoadScene("gameOver");
        else if(win)
            SceneManager.LoadScene("loading");
        

    }
}
