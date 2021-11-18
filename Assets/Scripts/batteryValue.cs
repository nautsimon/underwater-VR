using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class batteryValue : MonoBehaviour
{
    [SerializeField]
    [Tooltip("100%")]
    private string formatText = "{100}%";
    public AudioSource audioSource;
    private Text tmproTexts;

    private void Start()
    {
        
        tmproTexts = GetComponent<Text>();
        Debug.Log(tmproTexts.text);
        audioSource = GetComponent<AudioSource>();
        GetComponentInParent<Slider>().onValueChanged.AddListener(HandleBattValueChanged);
    }

    private void HandleBattValueChanged(float value)
    {
        Debug.Log("VLUE TEXT VALLL");
        Debug.Log(value);
        tmproTexts.text = string.Format(formatText, value);
        if (value == 15.0){
            Debug.Log("OSIOSDUOISDI");
            audioSource.Play();
        }
        
    }
}


