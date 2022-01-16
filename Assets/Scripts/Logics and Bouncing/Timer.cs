using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;

    [SerializeField] private float _countDown = 0f;

    public GameOverPopup GameOverPopup;
    public GameObject cannon;

    private bool _timerIsRunning = false;
    bool timeSet = false;

    private void Start()
    {
        _countDown = MaxTime;
        _timerIsRunning = true;
    }

    private void Update()
    {
        if(_timerIsRunning)
        {
            if (_countDown > 0)
            {
                _countDown -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                _countDown = 0;
                _timerIsRunning = false;
                GameOverPopup.Open();

                if (timeSet == false)
                {
                    Time.timeScale = 0;
                    timeSet = true;
                }
                cannon.GetComponent<FinalControllerPC>().enabled = false;
            }
        }
        
    }
}
