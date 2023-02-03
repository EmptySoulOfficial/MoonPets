using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacteristicType{
    neutral,
    positive,
    negative,
}

[CreateAssetMenu(fileName = "New Characteristic", menuName = "Characteristic")]
public class Characteristic : ScriptableObject
{
    public string characteristicName = "";
    public string characteristicDescription = "";


    public CharacteristicType characteristicType;
}
