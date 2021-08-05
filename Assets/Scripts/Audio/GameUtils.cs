using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils : MonoBehaviour
{
    public static void PlaySound(AudioClip clip, AudioSource audioplayer)
    {
        audioplayer.Stop();
        audioplayer.clip = clip;
        audioplayer.loop = false;
        audioplayer.time = 0;
        audioplayer.Play();
    }
}
