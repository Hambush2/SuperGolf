using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Explosion))]
public class ExplosionBlock : MonoBehaviour
{
    private Explosion _explosion;
    private bool _isActivated = false;

    private void Awake()
    {
        _explosion = GetComponent<Explosion>();
    }

    private void FixedUpdate()
    {
        if (_isActivated)
        {
            _explosion.Explode();
        }
    }

    public void SetActivate(bool isActivated)
    {
        _isActivated = isActivated;
    }
}
