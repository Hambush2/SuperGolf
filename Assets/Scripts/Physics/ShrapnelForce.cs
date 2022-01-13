using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrapnelForce : MonoBehaviour
{
    public float X, Y, Z;
    // Start is called before the first frame update
    void Awake() 
    {
        System.Random rand = new System.Random();
        X = rand.Next(25, 56);
        Z = rand.Next(25, 56);
        Y = this.transform.position.y;
        if(rand.Next(2) == 1) 
        {
            X = -X;
        }
        if(rand.Next(2) == 1) 
        {
            Z = -Z;
        }
        this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(X,Y,Z), ForceMode.Impulse);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Floor") 
        {
            Destroy(this.gameObject);
        }
        if (other.TryGetComponent(out ExplosionBlock explosionBlock))
        {
            explosionBlock.SetActivate(true);
            Destroy(explosionBlock.gameObject, 0.5f);
        }
    }
}
