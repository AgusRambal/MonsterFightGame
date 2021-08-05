using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControl : MonoBehaviour
{
    public GameObject[] characters;
    public Transform playerStartPosition;
    private string selectedCharacterDataName = "SelectedCharacter";
    public int selectedCharacter;
    public GameObject player;
    public GameObject foto1, foto2, foto3, foto4;

    public int roundTime;
    private float lasTimeUpdate;

    public BannerController banner;
    
    void Start()
    {
        if (AudioScenes.instance != null) //Pongo pausa a la cancion inicializada en el menu y utilizo un if para corregir el singletone
        {
            AudioScenes.Pause();
        }

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

        banner.showRoundFight();

    }

    private void Update()
    {
        if (roundTime > 0 && Time.time - lasTimeUpdate > 1)
        {
            roundTime--;
            lasTimeUpdate = Time.time;
        }
    }
}
 