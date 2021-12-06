using UnityEngine;

public class TaptoLaunchController : MonoBehaviour
{
    //Establish Variables

    //clocks that finds the shooting angle
    public float powerClock;
    public float angleClock;
    public bool reversePowerClock;
    public bool reverseAngleClock;
    public float clockSpeed;

    //number of taps
    public int tapCounter = 1;

    //ball object to launch
    public GameObject ball;
    public GameObject iball;
    public float multiplier;

    //Launch Angles
    public float X, power, angle;

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

                    break;

                //when the first touch leaves the screen record its end position
                case TouchPhase.Ended:
                    //launch the ball
                    tapCounter = Launch(tapCounter);
                    break;
            }
        }
    }

    //update on fixed intervals
    private void FixedUpdate()
    {
        //use clock to find the angle
        if (!reverseAngleClock && tapCounter == 1)
        {
            angleClock += clockSpeed;
        }
        else if (tapCounter == 1)
        {
            angleClock -= clockSpeed;
        }

        if (angleClock >= 700)
        {
            reverseAngleClock = true;
        }
        if (angleClock <= -700)
        {
            reverseAngleClock = false;
        }

        //use clock to find the power
        if (!reversePowerClock && tapCounter == 2)
        {
            powerClock += clockSpeed;
        }
        else if (tapCounter == 2)
        {
            powerClock -= clockSpeed;
        }

        if (powerClock >= 1000)
        {
            reversePowerClock = true;
        }
        if (powerClock <= 0)
        {
            reversePowerClock = false;
        }
    }

    int Launch(int tap)
    {
        if (tap == 1)
        {
            //set the angle
            angle = angleClock;

            return tap + 1;
        }
        else
        {
            //set the Y angle
            power = powerClock;

            //instantiate a copy of the ball object
            iball = Instantiate(ball, this.transform.position + offset, Quaternion.identity);

            //check if Y is negative
            if (power < 0)
            {
                power = power * -1;
            }

            //send it with force from input
            iball.GetComponent<Rigidbody>().AddForce(new Vector3(-power *multiplier, power*multiplier, angle), ForceMode.Impulse);
            tap = 1;

            //reset clocks
            angleClock = 0;
            powerClock = 0;
        }
        return tap;
    }
}
