using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool �spaused = false;

    public GameObject Panel;

    

    




    public void pause()
    {
        if (�spaused == true)
        {

            Time.timeScale = 1f;
            �spaused = false;
            Panel.SetActive(false);





        }
        else
        {

            Time.timeScale = 0f;
            �spaused = true;
            Panel.SetActive(true);
            
            
           

        }

        

        
       


       
        

    }

    
    

  


   





}
