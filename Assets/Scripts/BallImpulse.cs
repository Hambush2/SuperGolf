using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallImpulse : MonoBehaviour
{
    //public float force;
    Rigidbody rigidbody;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(direction, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
