using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stuffWriter : MonoBehaviour {

    public persoDataReceiver perso;
    public int slot = 0;

    Dropdown drop;

    // Use this for initialization
    void OnEnable()
    {
        drop = this.GetComponent<Dropdown>();

        ItemStack stuff = perso.PersoSlot(slot);

        if(stuff == null) drop.value = 0;
        else
        {
            drop.options.Add(new Dropdown.OptionData(stuff.itemObj.name));
            drop.value = 1;
        } 

        List<ItemStack> inventory = perso.inventorySlot(slot);
        
        for (int i = 0; i < inventory.Count; i++)
        {
            drop.options.Add(new Dropdown.OptionData(inventory[i].itemObj.name));
        }
    }

	public void OnChange()
    {
        
        ItemStack stuff = perso.PersoSlot(slot);
        
        if (stuff != null)
            perso.PersoSetSlot(slot, drop.value - 2);
        else
            perso.PersoSetSlot(slot, drop.value - 1);

        //perso.inventorySave();
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
