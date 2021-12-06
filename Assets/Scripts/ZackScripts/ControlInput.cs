using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInput : MonoBehaviour
{
    private Touch _touch;
    private Vector2 _touchStartPosition, _touchEndPosition;
    private BallLauncher _ballLauncher;

    private void Start()
    {
        _ballLauncher = FindObjectOfType<BallLauncher>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Began)
            {
                _touchStartPosition = _touch.position;
            }
            else if (_touch.phase == TouchPhase.Moved || _touch.phase == TouchPhase.Ended)
            {
                _touchEndPosition = _touch.position;
                _ballLauncher.Launch(_touchEndPosition - _touchStartPosition);
            }
        }
    }
}
