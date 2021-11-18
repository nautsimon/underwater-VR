using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeUnderwater : MonoBehaviour
{
   
    [SerializeField]
    [Tooltip("100%")]
    public Transform player;
    public int frames;
    public int seconds;
    private Text tmproText;
    // Start is called before the first frame update
    void Start()
    {
        tmproText = GetComponent<Text>();
        frames = 0;
        seconds = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.y);
        if(player.position.y < 12){
            frames = frames + 1;
            if(frames % 30 == 0){
                seconds = seconds + 1;
                tmproText.text = seconds.ToString("F0");
            }
        }

        
    }
}
