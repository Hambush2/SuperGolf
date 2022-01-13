using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    bool active = true;
    public void OnTriggerEnter(Collider other) 
    {
        if (active) 
        {
            if (other.TryGetComponent(out Ball ball))
            {
                // Add Points
                Debug.Log("+1");
            }
            if (other.tag == "Floor")
            {
                //Add points
                Debug.Log("+1F");
                if (gameObject.tag == "SolidBlock")
                {
                    //Stop script running
                    active = false;

                }
            }
        }
    }
}
