using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrapnelForce : MonoBehaviour
{
    public GameObject shrapnel;
    public float X, Y, Z;
    // Start is called before the first frame update
    void Awake() 
    {
        System.Random rand = new System.Random();
        X = rand.Next(15, 35);
        Z = rand.Next(15, 35);
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
        float xSpawn = 1.0f;
        float zSpawn = 1.0f;
        Vector3[] spawnCo = new Vector3[4];
        System.Random rand = new System.Random();

        if (other.tag == "Floor") 
        {
            Destroy(this.gameObject);
        }
        if (other.TryGetComponent(out ExplosionBlock explosionBlock))
        {
            explosionBlock.SetActivate(true);
            Destroy(explosionBlock.gameObject, 0.5f);
        }

        if (other.tag == "BreakBlock")
        {

            Destroy(other.gameObject);

            for (int count = 0; count < 4;)
            {
                //determining xSpawn coord
                if (rand.Next(2) == 1)
                {
                    xSpawn = -xSpawn;
                }
                //determining zSpawn coord
                if (rand.Next(2) == 1)
                {
                    zSpawn = -zSpawn;
                }
                spawnCo[count] = new Vector3(this.transform.position.x + xSpawn, this.transform.position.y, this.transform.position.z + zSpawn);
                count++;
            }
            Instantiate(shrapnel, spawnCo[0], Quaternion.identity);
            //Instantiate(shrapnel, spawnCo[1], Quaternion.identity);
            //Instantiate(shrapnel, spawnCo[2], Quaternion.identity);
            //Instantiate(shrapnel, spawnCo[3], Quaternion.identity);
        }
    }
}
