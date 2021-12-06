using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUI : MonoBehaviour
{
    public GameObject canon;
    public Slider LRSlider;
    public Slider powerSlider;

    // Update is called once per frame
    void Update()
    {
        if (canon.GetComponent<TaptoLaunchController>().isActiveAndEnabled)
        {
            //unhide sliders
            LRSlider.gameObject.SetActive(true);
            powerSlider.gameObject.SetActive(true);
            powerSlider.maxValue = 1000;

            //set slider to launch value
            LRSlider.value = canon.GetComponent<TaptoLaunchController>().angleClock;
            powerSlider.value = canon.GetComponent<TaptoLaunchController>().powerClock;
        }

        if (canon.GetComponent<SwipeController>().isActiveAndEnabled)
        {
            //hide sliders as they are not used here
            LRSlider.gameObject.SetActive(false);
            powerSlider.gameObject.SetActive(false);
        }

        if (canon.GetComponent<PullBackController>().isActiveAndEnabled)
        {
            //unhide sliders
            LRSlider.gameObject.SetActive(true);
            powerSlider.gameObject.SetActive(true);
            powerSlider.maxValue = 2200;

            //set slider to launch value
            LRSlider.value = -canon.GetComponent<PullBackController>().lrPullDis;
            powerSlider.value = -canon.GetComponent<PullBackController>().pullDis;
        }

        if (canon.GetComponent<HybridController>().isActiveAndEnabled)
        {
            //unhide sliders
            LRSlider.gameObject.SetActive(true);
            powerSlider.gameObject.SetActive(true);
            powerSlider.maxValue = 2200;

            //set slider to launch value
            LRSlider.value = canon.GetComponent<HybridController>().angleClock;
            powerSlider.value = -canon.GetComponent<HybridController>().pullDis;
        }
    }
}
