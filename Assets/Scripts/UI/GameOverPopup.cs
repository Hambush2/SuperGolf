using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverPopup : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private bool isOpened = false;
    [SerializeField] private TMP_Text _messageText;
    private bool _winningCondition = false;
 
    public void setCondition(bool cond)
    {
        _winningCondition = cond;
    }

    private void SetMessage()
    {
        if(_winningCondition)
        {
            _messageText.text = "Congratulations";
        }
        else
        {
            _messageText.text = "Unlucky";
        }
    }

    public void Open()
    {
        SetMessage();
        gameObject.SetActive(true);     
        _scoreText.text = Coin.Count.ToString();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void BackToMenu()
    {
        Debug.Log("Return to menu");
        GameManager.EndGame();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
