using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public  TMP_Text _timerText;

    private float _timer;
    private float _minutes;
    private float _seconds;


    private bool _stopTimer;

    void Start()
    {
        _stopTimer = false;
       
    }

    void Update()
    {
        if (!_stopTimer)
            _timer += Time.deltaTime;
    }

    private void OnGUI()
    {
        

        _minutes = Mathf.Floor(_timer / 60);
        _seconds = Mathf.RoundToInt(_timer % 60);
        _timerText.text = _minutes.ToString("00") + ":" + _seconds.ToString("00");


    }

    public float GetCurrentTime()
    {
        return _timer;
    }

    public void StopTimer()
    {
        _stopTimer = true;
    }
}
