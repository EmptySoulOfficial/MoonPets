using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType{
    none = 0,
    Food = 1,
    Drink = 2,
    Medicine = 3,
}

[CreateAssetMenu(fileName = "New Consumable", menuName = "Consumable Item")]
public class ConsumableItem : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;

    [Header("- Effects -")]
    public float addFood; 
    public float addDrink;
    public float addRest;
    public float addJoy;
    public float addHygiene;
    public float addToilet;
    public float addSocial;  
}
