using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform _hoursPivot, _minutesPivot, _secondsPivot;
    private const float _hourToDegrees = -30f, _minutesToDegrees = -6f, _secondsToDegree = -6f;

    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        _hoursPivot.localRotation = Quaternion.Euler(0f, 0f, _hourToDegrees * (float)time.TotalHours);
        _minutesPivot.localRotation = Quaternion.Euler(0f, 0f, _minutesToDegrees * (float)time.TotalMinutes);
        _secondsPivot.localRotation = Quaternion.Euler(0f, 0f, _secondsToDegree * (float)time.TotalSeconds);
    }
}
