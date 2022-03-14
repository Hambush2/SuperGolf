using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _maxTime = 60f;
    public float MaxTime { get { return _maxTime; } set { _maxTime = value; } }  

    [SerializeField] private float _countDown = 0f;
    public float CountDown { get { return _countDown; } set { _countDown = value; } }

    public GameOverPopup GameOverPopup;
    public GameObject cannon;

    private bool _timerIsRunning = false;
    bool timeSet = false;

    private void Start()
    {
        _countDown = _maxTime;
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
