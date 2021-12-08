using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid 
{

    
    private float speed = 500;
    public Rigidbody playerRb;
    private float turnRotation;
    public Animator animatorPlayer;
    public float animatorSecond;
    public float animHikma;

    

    public float Speed
    {

        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }

    }

    public float TurnRotation
    {

        get
        {
            return turnRotation;
        }

        set
        {
            turnRotation = value;
        }

    
    }


    public float animationpersecondtol
    {

        get
        {
            return animHikma;
        }

        set
        {
            animHikma = value;
        }

    }




}
