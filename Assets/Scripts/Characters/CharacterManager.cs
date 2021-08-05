using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] playerObjects;
    public int selectedCharacter = 0;

    private string selectedCharacterDataName = "SelectedCharacter";

    public void Start()
    {
        HideAllCharacters();

        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);

        playerObjects[selectedCharacter].SetActive(true);
    }

    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }

    public void NextCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter >= playerObjects.Length)
        {
            selectedCharacter = 0;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = playerObjects.Length - 1;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Gameplay");
    }

}
