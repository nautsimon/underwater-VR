using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class BatteryBar : MonoBehaviour
{

    private Slider slider;
    public InformationManager iM;
    private Text textSliderValue;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
        SetMaxBatteryLevel(iM.GetMaxBatteryLevel());
    }

    public void SetMaxBatteryLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
        Debug.Log(slider.value);
        Debug.Log("gkasdgasjhgd");
    }

    public void SetBatteryLevel (float level)
    {
        slider.value = level;
    }
    public void ShowSliderValue () {
    	string sliderMessage = "OXYGEN LEVEL= " + slider.value;
    	textSliderValue.text = sliderMessage;
    }

    private void Update()
    {
        SetBatteryLevel(iM.GetBatteryLevel());
    }
}
