using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{

    public Vector2 startPos; //start position
    public float timePressed; //clock
    public Vector2 endPos; //end position
    public float angle; //angle (not in degrees) value of the angleV vector

    //ball object to launch
    public GameObject ball;
    public GameObject iball;

    public float launchSpeed; //the speed at which the ball launches
    public float supressor = 1; //supresses the speed for the launch of the ball

    //canon offset
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //if there is a touch on screen (literally any number, change this later?)
        if (Input.touchCount > 0)
        {
            //get the 1st touch from the touch array
            Touch touch = Input.GetTouch(0);
            //start the timer
            timePressed += Time.deltaTime;

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //when the first touch is detected record its start position
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                //when the first touch leaves the screen record its end position
                case TouchPhase.Ended:
                    endPos = touch.position;
                    //create the launch angle (left.right)
                    angle = endPos.x - startPos.x;
                    //calculate the launch speed
                    launchSpeed = Vector2.Distance(startPos, endPos) / timePressed;
                    //reset the timer
                    timePressed = 0;
                    //LAUNCH
                    Launch();
                    break;
            }
        }
    }

    void Launch()
    {
        //instantiate a copy of the ball object
        iball = Instantiate(ball, this.transform.position + offset, Quaternion.identity);
        //send it with force from input
        iball.GetComponent<Rigidbody>().AddForce(new Vector3(-launchSpeed *supressor, launchSpeed *supressor, angle), ForceMode.Impulse);
    }
}
