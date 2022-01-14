using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingshotRotatorPC : MonoBehaviour
{
    public GameObject cannon;
    public float rotationDampner = 0.0002f;

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = new Quaternion(this.transform.rotation.x, -cannon.GetComponent<FinalControllerPC>().lrPullDis * rotationDampner, this.transform.rotation.z, this.transform.rotation.w);
    }
}
