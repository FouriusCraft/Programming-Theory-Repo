using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Humanoid player = new Humanoid();

    [SerializeField] float turnRotationfor;
    public static  float animationsolution;
    void Start()
    {
        player.playerRb = GetComponent<Rigidbody>();


        

    }

    // Update is called once per frame
    void Update()
    {
        
        player.TurnRotation = turnRotationfor;
        player.animHikma = animationsolution;
        PlayerMovementKey();
        

    }

    void PlayerMovementKey()
    {

        

        float verticalMovement = Input.GetAxis("Vertical");

        float horizontalMovement = Input.GetAxis("Horizontal");

        animationsolution = verticalMovement;

        player.playerRb.AddRelativeForce(Vector3.forward * verticalMovement *  player.Speed);

        player.playerRb.AddTorque(Vector3.up * horizontalMovement * player.TurnRotation, ForceMode.Impulse);

        animationsolution = verticalMovement;
       
    }

}
