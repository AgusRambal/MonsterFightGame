using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject[] characters;
    public Transform playerStartPosition;
    private string selectedCharacterDataName = "SelectedCharacter";
    public int selectedCharacter;
    public GameObject player;
    public GameObject foto1, foto2, foto3, foto4;
    
    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        player = Instantiate(characters[selectedCharacter], playerStartPosition.position, characters[selectedCharacter].transform.rotation);

        if (selectedCharacter == 0)
        {
            foto1.SetActive(true);
            foto2.SetActive(false);
            foto3.SetActive(false);
            foto4.SetActive(false);
        }
        else if (selectedCharacter == 1)
        {
            foto1.SetActive(false);
            foto2.SetActive(true);
            foto3.SetActive(false);
            foto4.SetActive(false);
        }
        else if (selectedCharacter == 2)
        {
            foto1.SetActive(false);
            foto2.SetActive(false);
            foto3.SetActive(true);
            foto4.SetActive(false);
        }
        else if (selectedCharacter == 3)
        {
            foto1.SetActive(false);
            foto2.SetActive(false);
            foto3.SetActive(false);
            foto4.SetActive(true);
        }

    }
}
 