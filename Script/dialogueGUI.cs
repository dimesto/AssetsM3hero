using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueGUI : MonoBehaviour {

    Canvas canva;

    public Image icon;
    public Text txt;

    public float TimeLef;

	// Use this for initialization
	void Start () {
        canva = this.GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Dialogue.Curent == "")
        {
            canva.enabled = false;
        }
        else
        {
            canva.enabled = true;

            if (Dialogue.dialogue.icone != null)
                icon.sprite = Dialogue.dialogue.icone;

            lang curLang = lang.findLang(PlayerPrefs.GetString("lang","Eng") , Dialogue.dialogue.group);

            txt.text = curLang.findText(Dialogue.dialogue.key).value;

            if(Input.GetButton("Submit") && TimeLef >= 0.2f)
            {
                Dialogue.Curent = Dialogue.dialogue.next;
                TimeLef = 0;
            }
            else
            {
                TimeLef += Time.deltaTime;
            }
        }
    }
}
