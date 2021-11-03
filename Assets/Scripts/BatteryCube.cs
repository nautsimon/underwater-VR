using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCube : MonoBehaviour
{

    public InformationManager im;
    private Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = (im.GetBatteryLevel()/im.GetMaxBatteryLevel()) * originalScale;
    }
}
