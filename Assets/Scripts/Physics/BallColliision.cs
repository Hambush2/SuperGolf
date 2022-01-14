using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColliision : MonoBehaviour
{
    public GameObject shrapnel;
    // Start is called before the first frame update
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
