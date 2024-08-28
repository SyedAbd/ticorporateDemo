using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{ 

    public string itemName;
    public string description;
    public Sprite icon;
    public int maxStack;

    
}

