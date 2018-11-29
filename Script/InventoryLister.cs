using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryLister : MonoBehaviour {
    

    public GameObject prefabItem;

	// Use this for initialization
	void Start ()
    {
        if (Save.inventory == null) Save.inventory = new InventoryData();

        for (int i = 0; i < Save.inventory.stacks.Count; i++)
        {
            GameObject go = GameObject.Instantiate(prefabItem, transform);
            go.GetComponent<ItemStackData>().idStack = i;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
