using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveUIclick : MonoBehaviour
{

    SaveInfo info;

    private void Start()
    {
        info = this.GetComponent<SaveInfo>();
    }

    public void OnClickUp()
    {
        Save.curSave = info.name;

        if(info.mode == SaveLister.SaveListerMode.load)
            Save.loadData();
        else if (info.mode == SaveLister.SaveListerMode.save)
            Save.SaveData();
    }

}
