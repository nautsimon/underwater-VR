using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class currentDepth : MonoBehaviour
{
   
    [SerializeField]
    [Tooltip("100%")]
    public Transform player;

    private Text tmproText;
    // Start is called before the first frame update
    void Start()
    {
        tmproText = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.y);
        tmproText.text = player.position.y.ToString("F0");
        
    }
}
