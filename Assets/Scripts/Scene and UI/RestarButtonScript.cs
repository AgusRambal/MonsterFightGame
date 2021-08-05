using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestarButtonScript : MonoBehaviour
{
    public void RestarScene()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}
