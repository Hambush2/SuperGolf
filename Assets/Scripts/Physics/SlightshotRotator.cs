using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlightshotRotator : MonoBehaviour
{
    public GameObject cannon;

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = new Quaternion(this.transform.rotation.x, -cannon.GetComponent<FinalController>().lrPullDis * 0.0002f, this.transform.rotation.z, this.transform.rotation.w);
    }
}
