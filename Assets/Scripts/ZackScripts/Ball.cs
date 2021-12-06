using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    public float JumpForce;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        JumpForce = _rigidbody.mass * 19.62f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Block block))
        {
            // Add Points
        }
        if (other.TryGetComponent(out Bounceable bounceable))
        {
            // Add Bouncing
            //_rigidbody.velocity = Vector3.zero;
            JumpForce /= 2 ;
            _rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

        }
    }
}
