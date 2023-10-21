using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
   public static SoundController Instance; //Mejorar esto
    [SerializeField] private AudioSource _soundFX;
    [SerializeField] private AudioSource _musicSource;
    //Audio mixer

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySound(AudioClip soundClip, float volume = 1.0f)
    {
        _soundFX.volume = volume;
        _soundFX.clip = soundClip;
        _soundFX.Play();
    }
    public void PlayMusic(AudioClip musicClip, float volume = 1.0f)
    {
        _musicSource.volume = volume;
        _musicSource.clip = musicClip;
        _musicSource.Play();
    }
    public void StopMusic()
    {
        _musicSource.Stop();
    }

    //Añadir para subir y bajar el volumen
}
