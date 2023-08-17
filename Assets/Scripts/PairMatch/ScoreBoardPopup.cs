using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardPopup : MonoBehaviour
{
    public GameObject ScorePopup;

    void Start()
    {
        ScorePopup.SetActive(false);
    }

    public void ScorePopupActive ()
    {
        ScorePopup.SetActive(true);
    }

    public void ScorePopupClose()
    {
        ScorePopup.SetActive(false);
    }
}
