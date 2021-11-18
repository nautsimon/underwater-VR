using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class batteryHandler : MonoBehaviour
{

    private Slider slider;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        SetMaxBatteryLevel(iM.GetMaxBatteryLevel());
    }

    public void SetMaxBatteryLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
    }

    public void SetBatteryLevel (float level)
    {
        slider.value = level;
    }


    private void Update()
    {
        Debug.Log(iM.GetBatteryLevel());
        SetBatteryLevel(iM.GetBatteryLevel());
    }
}
