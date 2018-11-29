using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSave : MonoBehaviour {

    public InputField field;
    
	public void set ()
    {
        Save.curSave = field.text;
        Save.SaveData();
    }
}
