using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PetType{
    none = 0,
    Cat = 1,
    Dog = 2,
}

[CreateAssetMenu(fileName = "New Moonpet", menuName = "Moonpet")]
public class MoonPet : ScriptableObject
{
    //public string iD = ""; //can be a name or number - must be unique
    public string petName = "New pet";
    public PetType petType; 

    [Header("- Visual Settings -")]

    public bool recolor = true;
    public Color primaryBodyColor;
    public Color secondaryBodyColor;
    public Color feetColor;
    public Color tailColor;
    public Material RightEyeMaterial;
    public Material LeftEyeMaterial; 
    [Header("")]

    public bool useSkinTexture = false;
    public Sprite texture;

    [Header("- Stats -")]
    public float health; 
    public float mood; //0 - 33,3 = bad; 33,4 - 66,6 = neutral; 66,7 - 100 = good;

    //Needs have default values depending on the pets zodiac sign. They change along with the pet's treatment and environment.
    [Header("- Needs -")]
    public float food; 
    public float drink;
    public float rest;
    public float joy;
    public float hygiene;
    public float toilet;
    public float social; 
    
}
