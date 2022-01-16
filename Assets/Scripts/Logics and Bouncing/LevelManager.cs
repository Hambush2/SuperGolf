using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float _winningCondition;
    [SerializeField] private GameOverPopup _GameOverPopup;

    public GameObject cannon;
    bool timeSet = false;

    private void Update()
    {
        if (Coin.Count > _winningCondition)
        {
            if(timeSet == false)
            {
                Time.timeScale = 0;
                timeSet = true;
            }

            GameObject.FindObjectOfType<Timer>().enabled = false;
            cannon.GetComponent<FinalControllerPC>().enabled = false;
            _GameOverPopup.setCondition(true);
            _GameOverPopup.Open();
        }
    }
}
