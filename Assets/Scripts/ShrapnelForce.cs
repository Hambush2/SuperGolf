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
        X = rand.Next(20, 51);
        Z = rand.Next(20, 51);
        Y = this.transform.position.y;
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
    }
}
