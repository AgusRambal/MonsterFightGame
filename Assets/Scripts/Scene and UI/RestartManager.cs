using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartManager : MonoBehaviour
{
    public GameObject gameOverText, restartButton;
    public static RestartManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            gameOverText.SetActive(false);
            restartButton.SetActive(false);
        }
    }

    public static void Gameover()
    {
        instance.gameOverText.SetActive(true);
        instance.restartButton.SetActive(true);
    }
}
