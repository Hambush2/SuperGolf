using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopUp : MonoBehaviour
{
    //[SerializeField] private GameManager _gameManager = null;
    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void BackToMenu()
    {
        GameManager.EndGame();
    }

    public void OnVolumeValue(float value)
    {
        Debug.Log("Volume has changed" + value);
    }
}
