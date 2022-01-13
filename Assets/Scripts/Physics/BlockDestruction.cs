using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockDestruction : MonoBehaviour
{
    public GameObject shrapnel;
    public int maxShrap;
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
        float xSpawn = 5.0f;
        float zSpawn = 5.0f;
        System.Random rand = new System.Random();

        if (other.tag == "Projectile")
        {
            
            for (int count = 0; count <= rand.Next(1, maxShrap + 1);)
            {
                //determining xSpawn coord
                if (rand.Next(2) == 1)
                {
                    xSpawn = -2;
                }
                //determining zSpawn coord
                if (rand.Next(2) == 1)
                {
                    zSpawn = -2;
                }
                Instantiate(shrapnel, this.transform.position + new Vector3(xSpawn,0,zSpawn), Quaternion.identity);
                count++;
            }
            Destroy(this.gameObject);

        }
    }
}
