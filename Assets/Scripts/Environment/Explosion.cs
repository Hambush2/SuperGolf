using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _power = 3.0f, _radius = 5.0f, _upForce = 1.0f;

    public void Explode()
    {
        Vector3 explosionPosition = this.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, _radius);

        foreach(Collider c in colliders)
        {
            Rigidbody rigidbody = c.GetComponent<Rigidbody>();
            if(rigidbody != null)
            {
                rigidbody.AddExplosionForce(_power, explosionPosition, _radius, _upForce, ForceMode.Impulse);
            }
            
        }
    }
}
