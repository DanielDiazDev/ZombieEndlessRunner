using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance;
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _sliderMusic;
    [SerializeField] private Slider _sliderSFX;
    [SerializeField] private AudioSource _sourceSFX;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadMusicVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
       
    }
    
    public void PlaySound(AudioClip clip)
    {
        _sourceSFX.clip = clip;
        _sourceSFX.PlayOneShot(clip);
    }   
    public void SetMusicVolume()
    {
        var volume = _sliderMusic.value;
        _mixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
        PlayerPrefs.Save();
    }
    public void SetSFXVolume()
    {
        var volume = _sliderSFX.value;
        _mixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
        PlayerPrefs.Save();
    }

    public void LoadMusicVolume()
    {
        _sliderMusic.value = PlayerPrefs.GetFloat("musicVolume");
        _sliderSFX.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
    }

    
}
