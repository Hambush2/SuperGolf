using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStats : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _timerDisplay;
    private Timer _timer;

    private void Awake()
    {
        _timer = FindObjectOfType<Timer>();
    }

    private void Update()
    {
        DisplayTime();
    }

    private void DisplayTime()
    {
        if (_timer.CountDown <= 0f)
        {
            HasTimeOut();
            return;
        }
        _timerDisplay.text = ConvertToTimeStandard();
    }

    private string ConvertToTimeStandard()
    {
        int minutes = (int)_timer.CountDown / 60;
        int seconds = (int)_timer.CountDown % 60;
        string answer = string.Format("{0:D2}m:{1:D2}s", minutes, seconds);
        return answer;
    }

    private void HasTimeOut()
    {
        _timerDisplay.enabled = false;
    }
}
