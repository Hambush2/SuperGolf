using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    public float LaunchVelocity = 1700f;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(_ball, transform.position, Quaternion.identity);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, LaunchVelocity, 0));
        }
    }
}
