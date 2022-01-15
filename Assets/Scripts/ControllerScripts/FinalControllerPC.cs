using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalControllerPC : MonoBehaviour
{
    //Establish Variables

    //position vector
    public Vector2 whilePos;

    //distance pulled back
    public float pullDis;

    //distance and angle pulled left or right/up or down
    public float startPos;
    public float lrPullDis;

    //ball object to launch
    public GameObject ball;
    public GameObject iball;

    //canon offset
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            startPos = Screen.height / 2;
            whilePos = Input.mousePosition;
            pullDis = whilePos.y - startPos;
            lrPullDis = whilePos.x - Screen.width / 2;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (pullDis < 0)
            {
                //launch the ball
                Launch();
            }
        }
    }

    void Launch()
    {
        //instantiate a copy of the ball object
        iball = Instantiate(ball, this.transform.position + offset, Quaternion.identity);
        //send it with force from input
        iball.GetComponent<Rigidbody>().AddForce(new Vector3(pullDis - 2000, -pullDis, -lrPullDis), ForceMode.Impulse);
        pullDis = 0;
    }

}
