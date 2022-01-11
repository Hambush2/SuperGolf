using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchScript : MonoBehaviour
{
    public GameObject ball;
    public float X, Y, Z;
    public float devX, devY, devZ;
    float zValMax = 10;
    float yValMax = 20;
    float yValMin = 0;
    public Vector3 offset; //-0.01979902 0.5331585 0.002999991
    GameObject IBall;
    bool ySet, zSet = false;
    public float inc = 0.5f;
    bool Max = true;

    // Start is called before the first frame update
    void Start()
    {
        //X = -10;
        //IBall = Instantiate(ball, this.transform.position + offset, Quaternion.identity);
        //IBall.GetComponent<Rigidbody>().AddForce(new Vector3(X, Y, Z), ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {



        LaunchAngleInput();


        
    }

    void LaunchAngleInput()
    {
        //Debug.Log("y: " + Y);
        //Debug.Log("valMax: " + -valMax);
        //Debug.Log("Compare: " + (Y >= -valMax).ToString());
        //Debug.Log("Max: " + Max.ToString());

        //Checking if X reaches max/min value
        //if (X >= valMax && xSet == false)
        //{
        //    Max = true;
        //}
        //else if (X <= -valMax && xSet == false)
        //{
        //    Max = false;
        //}


        //Checking if Y reaches max/min value
        if (Y >= yValMax && ySet == false)
        {
            Max = true;
        }
        else if (Y <= yValMin && ySet == false)
        {
            Max = false;
        }
        //Checking if Z reaches max/min value
        else if (Z >= zValMax && zSet == false)
        {
            Max = true;
        }
        else if (Z <= -zValMax && zSet == false)
        {
            Max = false;
        }


        //while the max isn't reached increases towards max
        //if (Max == false && xSet == false)
        //{
        //    X += inc;
        //}
        if (Max == false && ySet == false)
        {
            Y += inc;
        }
        else if (Max == false && zSet == false)
        {
            Z += inc;
        }


        //while the minimum isn't reached decreases towards min
        //if (Max == true && xSet == false)
        //{
        //    X -= inc;
        //}
        if (Max == true && ySet == false)
        {
            Y -= inc;
        }
        else if (Max == true && zSet == false)
        {
            Z -= inc;
        }


        if (Input.GetKeyDown("space") == true)
        {
            //if (xSet == false)
            //{
            //    xSet = true;
            //}
            if (ySet == false)
            {
                ySet = true;
            }
            else if (zSet == false)
            {
                zSet = true;
                this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().enabled = false;
                IBall = Instantiate(ball, this.transform.position + offset, Quaternion.identity);
                IBall.GetComponent<Rigidbody>().AddForce(new Vector3(X, Y, Z), ForceMode.Impulse);
            }


        }
        if (Input.GetKeyDown("n") == true)
        {
            ySet = true;
            zSet = true;

            IBall = Instantiate(ball, this.transform.position + offset, Quaternion.identity);
            IBall.GetComponent<Rigidbody>().AddForce(new Vector3(devX, devY, devZ), ForceMode.Impulse);

        }

        if (ySet == false) 
        {
            float y10 = Y - 10;
            this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Y: " + FloatShrink(y10);
        }
        else if (zSet == false)
        {
            //this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color = Color.blue;
            this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Z: " + FloatShrink(Z);
            
        }
    }

    string FloatShrink(float val)
    {
        string vString = val.ToString();
        int pIndex = 0;
        string outString = "";

        for (int count = 0; count < vString.Length;)
        {
            if (vString[count] == '.')
            {
                pIndex = count;
                count = vString.Length;
            }
            count++;
        }

        for (int count = 0; count < pIndex;)
        {
            outString = outString + vString[count];
            count++;
        }
        return outString;
    }
}
