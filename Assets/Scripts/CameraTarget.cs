using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Transform targetPoint;
    public float cameraUp = 20;
    public float cameraBack = 5;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Player");

        targetPoint = ball.transform;
        //transform.LookAt(targetPoint);

        transform.position = new Vector3(targetPoint.position.x + cameraBack, targetPoint.position.y + cameraUp, targetPoint.position.z );
    }
}
