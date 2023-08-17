using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject playBtn;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void PauseControl ()
    {
        if (Time.timeScale == 1)
        {
            playBtn.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            playBtn.SetActive(false);
        }
    }
}
