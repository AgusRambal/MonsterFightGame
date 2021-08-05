using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaceneSelection : MonoBehaviour
{
    public void Awake()
    {
        Time.timeScale = 1f;    
    }

    public void CambioBTN(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}