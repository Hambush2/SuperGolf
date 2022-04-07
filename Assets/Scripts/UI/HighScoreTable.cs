using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreTable : MonoBehaviour
{
    [SerializeField] private Transform _entryContainer;
    [SerializeField] private Transform _entryTemplate;

    private void Awake()
    {

        _entryTemplate.gameObject.SetActive(false);

        float templateHeight = 10f;
        for(int i = 0; i < 5; i++)
        {
            Transform entryTransform = Instantiate(_entryTemplate, _entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);
        }
    }
}
