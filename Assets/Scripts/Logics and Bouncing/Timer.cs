using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;

    [SerializeField] private float _countDown = 0f;

    public GameOverPopup GameOverPopup;

    private bool _timerIsRunning = false;

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
            }
        }
        
    }
}
