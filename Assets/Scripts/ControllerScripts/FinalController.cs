using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalController : MonoBehaviour
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

    //percentage variables
    public float screenSizePercentH;
    public float screenSizePercentW;

    // Start is called before the first frame update
    void Start()
    {
        //get screen size percentage
        screenSizePercentH = (Screen.height / Screen.height) * 100;
        screenSizePercentW = (Screen.width / Screen.width) * 100;
    }

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
                //when the first touch is detected 
                case TouchPhase.Began:
                    
                    break;

                //while a finger is on screen find its position and calculate release power
                case TouchPhase.Moved:
                    startPos = Screen.height / 2;
                    whilePos = touch.position;
                    pullDis = whilePos.y - startPos;
                    lrPullDis = whilePos.x - Screen.width / 2;
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
        iball.GetComponent<Rigidbody>().AddForce(new Vector3(1.2f*pullDis, -pullDis, -lrPullDis), ForceMode.Impulse);
        pullDis = 0;
    }

}
