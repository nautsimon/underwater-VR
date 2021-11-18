using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class oxygenSliderColor : MonoBehaviour
{
    // Start is called before the first frame update
    public Image fill;
    void Start()
    {
        fill = GetComponentInParent<Slider>().GetComponentsInChildren<UnityEngine.UI.Image>().FirstOrDefault(t => t.name == "Fill");
        GetComponentInParent<Slider>().onValueChanged.AddListener(HandleValueChanged);

    }

    // Update is called once per frame

    private void HandleValueChanged(float value)
    {
       fill.color = Color.Lerp(Color.red, Color.cyan, value/100);
    }

}


    // private Image Fill;
    // void Start()
    // {
    //     GetComponentInParent<Slider>().onValueChanged.AddListener(HandleValueChanged);
    // }
    // private void HandleValueChanged(float value)
    // {
    //     Fill.GetComponent<Image>().color =Color.red;
    // }