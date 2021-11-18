using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class batterySliderColor : MonoBehaviour
{
    // Start is called before the first frame update
    public Image fill;
    void Start()
    {
        fill = GetComponentInParent<Slider>().GetComponentsInChildren<UnityEngine.UI.Image>().FirstOrDefault(t => t.name == "Fill");
        Debug.Log(fill);
        GetComponentInParent<Slider>().onValueChanged.AddListener(HandleBattValueChanged);

    }

    // Update is called once per frame

    private void HandleBattValueChanged(float value)
    {
        Debug.Log("COLOR VALLL");
        Debug.Log(value);
        fill.color = Color.Lerp(Color.red, Color.green, value/100);
    }

}