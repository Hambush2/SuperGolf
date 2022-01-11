using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicBoom : MonoBehaviour
{
    public bool IsEnoughPower;
    public float Force;
    private Ball _ball;
    private Rigidbody _rigidbody;
    private Transform _transform;

    private void Start()
    {
        _ball = (Ball)FindObjectOfType<Ball>();
        if(_ball.TryGetComponent(out Rigidbody rigidbody))
        {
            _rigidbody = rigidbody;
        }
        if(_ball.TryGetComponent(out Transform transform))
        {
            _transform = transform;
        }
    }

    private void Update()
    {
        if(IsEnoughPower)
        {
            if(Input.GetButton("Fire1"))
            {
                _rigidbody.AddExplosionForce(Force, _transform.position, 0.3f, 3.0f);
            }
        }
    }
}
