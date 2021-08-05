using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip clickFX;

    public void clickSound()
    {
        myFX.PlayOneShot(clickFX);
    }
}
