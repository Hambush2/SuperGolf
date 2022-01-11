using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Transform _spawnPoint;
    public float LaunchVelocity = 1700f;

    public void Launch(Vector3 force)
    {
        GameObject ball = Instantiate(_ball, _spawnPoint.transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(force.x, force.y, force.y) * LaunchVelocity);
    }
}
