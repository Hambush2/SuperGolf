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

    //percentage variables
    float screenSizePercentH;
    float screenSizePercentW;

    //cannon power amplifier
    public float canonPower = 10;
    public float rotationPower = 10;

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
        if (Input.GetMouseButton(0))
        {
            startPos = screenSizePercentH / 2;
            whilePos.y = (Input.mousePosition.y / Screen.height) *100;
            whilePos.x = (Input.mousePosition.x / Screen.width) * 100;
            pullDis = whilePos.y - startPos;
            lrPullDis = whilePos.x - screenSizePercentW / 2;
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
        iball.GetComponent<Rigidbody>().AddForce(new Vector3(pullDis*canonPower, -pullDis * canonPower, -lrPullDis * rotationPower), ForceMode.Impulse);
        pullDis = 0;
    }

}
