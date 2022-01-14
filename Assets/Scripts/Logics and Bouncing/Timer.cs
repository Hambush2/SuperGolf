using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;

    [SerializeField] private float _countDown = 0f;

    public GameOverPopup GameOverPopup;

    private void Start()
    {
        _countDown = MaxTime;
    }

    private void Update()
    {
        _countDown -= Time.deltaTime;

        if(_countDown <= 0)
        {
            Debug.Log("The game should end");
            GameOverPopup.Open();
        }
    }
}
