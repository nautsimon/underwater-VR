using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudStorm : MonoBehaviour
{

    public GameObject mudGO;
    public Camera playerCamera;
    public Underwater underwaterScript;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MudSurpriseOn");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MudSurpriseOn()
    {
        yield return new WaitForSeconds(Random.Range(15f, 40f));
        if (underwaterScript.IsUnderwater(playerCamera))
        {
            Debug.Log("Mud slide.");
            playerCamera.cullingMask &= ~(1 << LayerMask.NameToLayer("User")); // Hide
            mudGO.SetActive(true);
            underwaterScript.waterFogDensity = 0.4f;
            StartCoroutine("MudSurpriseOff");
        } else
        {
            Debug.Log("Not in water for mud.");
            StartCoroutine("MudSurpriseOn");
        }
    }

    IEnumerator MudSurpriseOff()
    {
        yield return new WaitForSeconds(20f);
        Debug.Log("Mud slide subsided.");
        playerCamera.cullingMask |= 1 << LayerMask.NameToLayer("User"); // Show
        mudGO.SetActive(false);
        underwaterScript.waterFogDensity = 0.05f;
    }
}
