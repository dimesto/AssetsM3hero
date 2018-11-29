using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateChangeButton : MonoBehaviour
{
    public string find;
    public string replace; 

	public void OnClickUp()
    {
        GameStat.curent = GameStat.curent.Replace(find, replace);
	}
}
