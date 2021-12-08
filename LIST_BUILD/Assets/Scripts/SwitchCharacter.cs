using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject avatar1, avatar2;

    [SerializeField] int whichAvatarIsOn = 1;


    private void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
    }

    public void SwitchAvatarDesu()
    {
        switch (whichAvatarIsOn)
        {
            case 1:

                whichAvatarIsOn = 2;

                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);

                break;

            case 2:

                whichAvatarIsOn = 1;

                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);

                break;
        } 
    }

}
