using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootZone : MonoBehaviour {

    public string item;
    public int qte;

    public GameObject inactiv;

    public bool playerIn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerIn = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerIn = false;
    }

    private void Update()
    {
        if(Input.GetButton("Submit") && playerIn)
        {
            if (Save.inventory == null) Save.inventory = new InventoryData();
            Save.inventory.stacks.Add(new ItemStack(item,qte));
            inactiv.SetActive(false);
        }
    }
}
