using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemStack
{

    public ItemStack(string item, int qte)
    {
        this.idItem = item;
        this.qte = qte;
    }

    public string idItem;
    public int qte;

    public Item itemObj
    {
        get
        {
            return Item.find(idItem);
        }
    }

}
