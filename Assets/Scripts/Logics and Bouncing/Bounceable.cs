using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounceable : MonoBehaviour
{
    public void Bounce(float force, Vector3 centre, float radius)
    {
        if(TryGetComponent(out Rigidbody rigidbody))
        {
            //rigidbody.AddExplosionForce(force, centre, radius);
        }
    }
}
