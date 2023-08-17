using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backsound : MonoBehaviour
{
    private AudioSource _audioSource;
    private bool muteBacksound = false;

    void Start()
    {
        SoundManager.instance.MuteBackgroundMusic();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
    }

    public void SilienceBacksound()
    {
        muteBacksound = !muteBacksound;
        if (muteBacksound)
        {
            _audioSource.volume = 0f;
        }
        else
        {
            _audioSource.volume = 1f;
        }
    }



}
