using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatPerso : MonoBehaviour
{


    public persoDataReceiver perso;
    public GameObject go;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            go.SetActive(false);

        if (GameStat.curent.Contains("Perso" + perso.IdPerso))
        {
            go.SetActive(true);
        }
    }
}
