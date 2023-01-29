using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPet : MonoBehaviour
{
    public MoonPet moonPet;

    //public GameObject body;

    [Header("- Components -")]
    public SpriteRenderer s_body;
    public SpriteRenderer s_head;

    public SpriteRenderer s_ear_r;
    public SpriteRenderer s_ear_l;
    public SpriteRenderer s_ear_inner_r;
    public SpriteRenderer s_ear_inner_l;

    public SpriteRenderer s_eye_r;
    public SpriteRenderer s_eye_l;
    public SpriteRenderer s_eye_inner_r;
    public SpriteRenderer s_eye_inner_l;

    public SpriteRenderer s_foot_r;
    public SpriteRenderer s_foot_l;

    public SpriteRenderer s_nose;
    public SpriteRenderer s_tail;

    [Header("- Dev Mode -")]
    public bool realtimeColorChange;
    
    // Start is called before the first frame update
    void Start()
    {
        SetColors();
    }

    // Update is called once per frame
    void Update()
    {
        if(realtimeColorChange == true){
            SetColors();
        }
    }

    void SetColors(){
        s_body.color = moonPet.primaryBodyColor;
        s_tail.color = moonPet.primaryBodyColor;
        s_head.color = moonPet.primaryBodyColor;

        s_ear_r.color = moonPet.primaryBodyColor;
        s_ear_l.color = moonPet.primaryBodyColor;

        s_foot_r.color = moonPet.primaryBodyColor;
        s_foot_l.color = moonPet.primaryBodyColor;

        //s_eye_r.color = moonPet.RightEyeColor; -> color gradient?
        //s_eye_l.color = moonPet.LeftEyeColor; 

        //s_eye_inner_r.color = Color.black; -> black by default
        //s_eye_inner_l.color = Color.black; 
    }
}
