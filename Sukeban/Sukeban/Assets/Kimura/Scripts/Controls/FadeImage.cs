using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour
{
    [SerializeField]
    private float _fadeTime = 1.0f;

    private float _fadeValue = 1.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            StartCoroutine(FadeIn());
        }

        if(Input.GetMouseButtonUp(0))
        {
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeIn()
    {
        _fadeValue = 1.0f;
        var img = GetComponent<Image>();
        while(_fadeValue>0)
        {
            _fadeValue -= (1.0f / _fadeTime) * Time.deltaTime;
            if(_fadeValue < 0)
                _fadeValue = 0;
            img.fillAmount=_fadeValue;
            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        _fadeValue = 0.0f;
        var img = GetComponent<Image>();
        while(_fadeValue < 1.0f)
        {
            _fadeValue += (1.0f / _fadeTime) * Time.deltaTime;
            if(_fadeValue > 1.0f)
            _fadeValue = 1.0f;
            img.fillAmount = _fadeValue;
            yield return null;
        }
    }

}
