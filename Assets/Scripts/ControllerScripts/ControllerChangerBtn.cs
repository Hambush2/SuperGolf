using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerChangerBtn : MonoBehaviour
{
    //variables
    public GameObject cannon;
    public Button button;
    public int loopCounter;

    // Start is called before the first frame update
    void Start()
    {
        if (cannon.GetComponent<TaptoLaunchController>().isActiveAndEnabled)
        {
            button.GetComponentInChildren<Text>().text = "\"Tap To Launch\" Controller";
            loopCounter = 1;
        }
        if (cannon.GetComponent<PullBackController>().isActiveAndEnabled)
        {
            button.GetComponentInChildren<Text>().text = "\"Pull Back\" Controller";
            loopCounter = 2;
        }
        if (cannon.GetComponent<SwipeController>().isActiveAndEnabled)
        {
            button.GetComponentInChildren<Text>().text = "\"Swipe\" Controller";
            loopCounter = 3;
        }
        if (cannon.GetComponent<HybridController>().isActiveAndEnabled)
        {
            button.GetComponentInChildren<Text>().text = "\"Hybrid\" Controller";
            loopCounter = 4;
        }

        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if(loopCounter == 1)
        {
            button.GetComponentInChildren<Text>().text = "\"Pull Back\" Controller";
            cannon.GetComponent<HybridController>().enabled = false;
            cannon.GetComponent<PullBackController>().enabled = true;
            loopCounter = 2;
        }
        else if(loopCounter == 2)
        {
            button.GetComponentInChildren<Text>().text = "\"Swipe\" Controller";
            cannon.GetComponent<PullBackController>().enabled = false;
            cannon.GetComponent<SwipeController>().enabled = true;
            loopCounter = 3;
        }
        else if(loopCounter == 3)
        {
            button.GetComponentInChildren<Text>().text = "\"Tap To Launch\" Controller";
            cannon.GetComponent<SwipeController>().enabled = false;
            cannon.GetComponent<TaptoLaunchController>().enabled = true;
            loopCounter = 4;
        }
        else if (loopCounter == 4)
        {
            button.GetComponentInChildren<Text>().text = "\"Hybrid\" Controller";
            cannon.GetComponent<TaptoLaunchController>().enabled = false;
            cannon.GetComponent<HybridController>().enabled = true;
            loopCounter = 1;
        }
    }
}
