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
    public Gradient RightEyeColor;
    public Gradient LeftEyeColor; 
    [Header("")]

    public bool useSkinTexture = false;
    public Sprite texture;

    [Header("- Stats -")]
    public float health;
    public float hunger;
    public float thirst;
    public float joy;
    public float hygiene;
    public float toilet;

    //[Header("- Behaviour -")]
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
