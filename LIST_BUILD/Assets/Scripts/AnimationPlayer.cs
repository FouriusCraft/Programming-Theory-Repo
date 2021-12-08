using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    public Animator animatorPlayerDesu;
    void Start()
    {
        animatorPlayerDesu = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       

       
            animatorPlayerDesu.SetFloat("Speed_f", Player.animationsolution);
        
        
    }
}
