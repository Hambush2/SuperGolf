using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        Instantiate(_ball, _spawnPoint.position, Quaternion.identity);
    }
}
