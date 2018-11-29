using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStackData : MonoBehaviour {
    
    public int idStack;
    
    public string item
    {
        get
        {
            return Save.inventory.stacks[idStack].idItem;
        }
    }
    public string itemName
    {
        get
        {
            return Item.find(item).name;
        }
    }
    public int qte
    {
        get
        {
            return Save.inventory.stacks[idStack].qte;
        }
    }
}
