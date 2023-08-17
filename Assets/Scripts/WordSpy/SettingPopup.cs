using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopup : MonoBehaviour
{

    public GameObject settingPopup;

    void Start()
    {
        settingPopup.SetActive(false);
    }

    

    public void ShowSettingPopup()
    {
        settingPopup.SetActive(true);

    }

    public void CloseSettingPopup()
    {
        settingPopup.SetActive(false);
    }

}
