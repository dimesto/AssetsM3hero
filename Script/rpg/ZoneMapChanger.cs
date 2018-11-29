using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneMapChanger : MonoBehaviour {

    public string map = "";
    public Vector2 loc = Vector2.zero; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("enter");
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("loading", LoadSceneMode.Single);


            if (Save.info == null)
                Save.info = new GameInfo();

            Save.info.MapName = map;
            Save.info.MapX = loc.x;
            Save.info.MapY = loc.y;
			
			MonsterLogic.monsterFight.Clear();
			
            //Save.quickSaveData();

            /*
            PlayerPrefs.SetString("Map", map);
            PlayerPrefs.SetFloat("MapX", loc.x);
            PlayerPrefs.SetFloat("MapY", loc.y);
            */
        }
    }
}
