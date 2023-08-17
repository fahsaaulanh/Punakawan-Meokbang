using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    private bool _muteBackgroundMusic = false;
    private bool _muteSoundFx = false;
    public static SoundManager instance;

    public AudioSource _audioSource;
    private float UpdateVol;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }




    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
       
    }

    void Update()
    {
        
    }


    public void VolumeSet (float vol)
    {
        _audioSource.volume = vol;
    }

    public float GetUpdateVolume ()
    {
        return _audioSource.volume;
    }

    public void ToggleBackgroundMusic()
    {
        _muteBackgroundMusic = !_muteBackgroundMusic;
        if (_muteBackgroundMusic)
        {
            _audioSource.Stop();
        }
        else
        {
            _audioSource.Play();
        }
    }


    public void ToggleSoundFX()
    {
        _muteSoundFx = !_muteSoundFx;
        GameEvents.OnToggleSoundFXMethod();
    }

    public void MuteBackgroundMusic()
    {
        _audioSource.Stop();
    }

    public void UnMuteBackgroundMusic()
    {
        _audioSource.Play();
    }

    public bool IsBackgroundMusicMuted()
    {
        return _muteBackgroundMusic;
    }

    public bool IsSoundFXMuted()
    {
        return _muteSoundFx;
    }

   
    public void SilienceBackgroundMusic(bool silience)
    {
        if (_muteBackgroundMusic == false)
        {
            if (silience)
                _audioSource.volume = 0f;
            else
                _audioSource.volume = 1f;
        }
    }

   
}
