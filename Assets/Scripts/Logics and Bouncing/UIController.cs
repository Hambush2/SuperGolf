using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private SettingsPopUp _settingsPopUp;

    private void Start()
    {
        _settingsPopUp.Close();
    }

    public void OpenSettingsMenu()
    {
        Debug.Log("Open Settings");
        _settingsPopUp.Open();
    }
}
