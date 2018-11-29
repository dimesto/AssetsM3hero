using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLister : MonoBehaviour {

    public GameObject prefabUI;
    public SaveListerMode mode;


    public void create()
    {
        Save.create();
    }

    // Use this for initialization
    public void updateSaveList ()
    {
        for (int i = 0;i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        string[] str = Save.ListSave;

        for(int i = 0; i< Save.coutSave; i++)
        {
            GameObject go = GameObject.Instantiate(prefabUI, transform);
            go.GetComponent<SaveInfo>().name = str[i];
            go.GetComponent<SaveInfo>().mode = mode;
        }
		
	}

    private void OnEnable()
    {
        updateSaveList();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public enum SaveListerMode
    {
        save,
        load,
        list
    }
}
