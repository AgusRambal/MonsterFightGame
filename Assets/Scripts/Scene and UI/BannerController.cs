using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerController : MonoBehaviour
{
    public Animator animator;
    private AudioSource audioPlayer;

    public bool animating;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioPlayer = GetComponent<AudioSource>();
    }

    public void showRoundFight()
    {
        animating = true;
        animator.SetTrigger("Round1");
    }

    public void showYouWin()
    {
        animating = true;
        animator.SetTrigger("Win");
    }

    public void showYouLose()
    {
        animating = true;
        animator.SetTrigger("Lose");
    }

    public void playVoice(AudioClip voice)
    {
        GameUtils.PlaySound(voice, audioPlayer);
    }
}
