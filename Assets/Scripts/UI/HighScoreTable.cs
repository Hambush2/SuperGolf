using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreTable : MonoBehaviour
{
    private Transform _entryContainer;
    private Transform _entryTemplate;

    private void Awake()
    {
        _entryContainer = transform.Find("");
        _entryTemplate = transform.Find("HighScoreTemplate");

        _entryTemplate.gameObject.SetActive(false);

    }
}
