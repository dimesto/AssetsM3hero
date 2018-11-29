using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatActiv : MonoBehaviour
{

    public string startGameStat;

    public List<GameStatfield> field = new List<GameStatfield>();
    // Use this for initialization
    void Start()
    {
        if (startGameStat != "")
            GameStat.curent = startGameStat;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < field.Count; i++)
        {
            if (GameStat.curent.Contains(field[i].state))
            {
                field[i].go.SetActive(true);
            }
            else
            {
                field[i].go.SetActive(false);

            }

        }
    }
}
[System.Serializable]
public class GameStatfield
{
    public string state;
    public GameObject go;
}
