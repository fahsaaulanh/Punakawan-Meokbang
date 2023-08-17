﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPopup : MonoBehaviour
{
    public GameObject gameOverPopup;

    void Start()
    {
        gameOverPopup.SetActive(false);

        GameEvents.OnGameOver += ShowGameOverPopup;

    }

    private void OnDisable()
    {
        GameEvents.OnGameOver -= ShowGameOverPopup;
    }

    private void ShowGameOverPopup()
    {
        gameOverPopup.SetActive(true);

    }


}
