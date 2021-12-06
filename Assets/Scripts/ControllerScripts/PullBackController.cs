using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullBackController : MonoBehaviour
{
    //Establish Variables

    //position vectors
    public Vector2 startPos;
    public Vector2 whilePos;

    //distance pulled back
    public float pullDis;

    //distance and angle pulled left or right
    public float lrPullDis;

    //ball object to launch
    public GameObject ball;
    public GameObject iball;

    //canon offset
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //if there is a touch on the screen
        if (Input.touchCount > 0)
        {
            //get 1st touch from array
            Touch touch = Input.GetTouch(0);

            //Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //when the first touch is detected record its start position
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                //while a finger is on screen find its position and calculate release power
                case TouchPhase.Moved:
                    whilePos = touch.position;
                    pullDis = whilePos.y - startPos.y;
                    lrPullDis = whilePos.x - Screen.width/2;
                    break;

                //when the first touch leaves the screen record its end position
                case TouchPhase.Ended:
                    whilePos = touch.position;
                    if (pullDis < 0)
                    {
                        //launch the ball
                        Launch();
                    }
                    break;
            }
        }
    }

    void Launch()
    {
        //instantiate a copy of the ball object
        iball = Instantiate(ball, this.transform.position + offset, Quaternion.identity);
        //send it with force from input
        iball.GetComponent<Rigidbody>().AddForce(new Vector3(pullDis, -pullDis, -lrPullDis), ForceMode.Impulse);
    }
}
