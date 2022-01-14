using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverPopup : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private bool isOpened = false;


    public void Open()
    {
        gameObject.SetActive(true);
        _scoreText.text = Coin.Count.ToString();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void BackToMenu()
    {
        GameManager.EndGame();
    }

    public void RestartLevel()
    {
        GameManager.StartGame();
    }
}
