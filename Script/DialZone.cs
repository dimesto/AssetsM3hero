using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialZone : MonoBehaviour {
    
    public string key;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dialogue.Curent = key;


        if (Save.info == null) Save.info = new GameInfo();
        Save.info.SetLogic(key, false);
    }
}
