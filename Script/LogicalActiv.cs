using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalActiv : MonoBehaviour
{
    public string key;

    // Update is called once per frame
    void Update () {

        if (Save.info == null) Save.info = new GameInfo();
        bool valu = Save.info.getLogic(key , true);

        if (valu == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
		
	}
}
