using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController1 : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private SettingsPopUp1 _settingsPopUp;

    private void Start()
    {
        _settingsPopUp.Close();
    }

    private void Update()
    {
        _scoreText.text = Coin.Count.ToString();
    }

    public void OpenSettingsMenu()
    {
        Debug.Log("Open Settings menu");
        _settingsPopUp.Open();
    }
}
