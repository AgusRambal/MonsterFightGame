using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerController : MonoBehaviour
{
    public Animator animator;

    public bool animating;

    void Start()
    {
        animator = GetComponent<Animator>();
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
}
