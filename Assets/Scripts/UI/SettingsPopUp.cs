using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopUp : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void OnVolumeValue(float value)
    {
        Debug.Log("Volume has changed" + value);
    }
}
