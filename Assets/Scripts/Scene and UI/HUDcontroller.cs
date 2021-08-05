using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDcontroller : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public GameControl battle;
    
    void Update()
    {
        timerText.text = battle.roundTime.ToString();
    }
}
