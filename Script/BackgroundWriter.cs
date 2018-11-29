using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundWriter : MonoBehaviour
{

    Image img;

    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();
        if(Fight.CurFight == null) Fight.CurFight = Fight.find("woodFight");
    }

    // Update is called once per frame
    void Update()
    {
        if(Fight.CurFight)
        img.sprite = Fight.CurFight.background;
    }
}
