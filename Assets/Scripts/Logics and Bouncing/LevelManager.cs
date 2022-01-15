using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float _winningCondition;
    [SerializeField] private GameOverPopup _GameOverPopup;

    private void Update()
    {
        if (Coin.Count > _winningCondition)
        {
            GameObject.FindObjectOfType<Timer>().enabled = false;
            _GameOverPopup.setCondition(true);
            _GameOverPopup.Open();
        }
    }
}
