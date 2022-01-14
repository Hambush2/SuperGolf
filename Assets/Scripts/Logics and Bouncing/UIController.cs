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

    private void Update()
    {
        _scoreText.text = Coin.Count.ToString();
    }

    public void OpenSettingsMenu()
    {
        _settingsPopUp.Open();
    }
}
