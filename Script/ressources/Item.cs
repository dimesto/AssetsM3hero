using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/basic", order = 1)]
public class Item : ScriptableObject
{
    public string name;
    public string description;

    public static Item find(string file)
    {
        return Resources.Load<Item>("item/"+file);
    }
}
