using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private void Start()
    {
        instance = this;
    }

    public static void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Coin.Count = 0;
    }

    public static void EndGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void StartLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public static void NextLevel()
    {
        Coin.Count = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
