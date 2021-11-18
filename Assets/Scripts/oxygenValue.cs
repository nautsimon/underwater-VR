using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class oxygenValue : MonoBehaviour
{
    [SerializeField]
    [Tooltip("100%")]
    private string formatText = "{100}%";

    private Text tmproText;

    private void Start()
    {
        tmproText = GetComponent<Text>();

        GetComponentInParent<Slider>().onValueChanged.AddListener(HandleValueChanged);
    }

    private void HandleValueChanged(float value)
    {
        tmproText.text = string.Format(formatText, value);
    }
}


