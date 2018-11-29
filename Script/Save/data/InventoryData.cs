using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryData
{
    public List<ItemStack> stacks = new List<ItemStack>();

    public InventoryData()
    {
        stacks.Add(new ItemStack("basicAxe", 1));
        stacks.Add(new ItemStack("smallPotion", 1));
    }
}
