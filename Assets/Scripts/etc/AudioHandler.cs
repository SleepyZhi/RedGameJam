using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private Slider musicSlider = null;
    [SerializeField] private Slider sfxSlider = null;

    [SerializeField] private AudioSource music = null;
    [SerializeField] private AudioSource sfx = null;
    void Start()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.GetFloat("MusicVolume", 0.2f);
            Save();
        }
        music.volume = PlayerPrefs.GetFloat("MusicVolume");
        sfx.volume = PlayerPrefs.GetFloat("SFXVolume");

        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }

    public void ChangeVolume()
    {
        music.volume = musicSlider.value;
        sfx.volume = sfxSlider.value;
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
    }

}
