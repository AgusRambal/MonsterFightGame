using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScenes : MonoBehaviour
{
    AudioSource audioSource;
    public static AudioScenes instance; //Se crea un singletone para que permanezca el dontdestroyonload correctamente
    private void Awake()
    {
        if (AudioScenes.instance == null) //Si esta instancia de script esta en on el audio no se destruye al cambiar de escena, sino si
        {
            AudioScenes.instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void Pause()
    {
        instance.audioSource.Pause();
    }
    public static void UnPause()
    {
        instance.audioSource.UnPause();
    }
}
