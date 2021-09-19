using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    public static int coinAncount = 0;

    void Start()
    {

        text = transform.GetComponent<Text>();

    }


    void Update()
    {
       
        text.text = coinAncount.ToString();
        
    } 
    
    
}


