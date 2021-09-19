using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFFECTS : MonoBehaviour
{
    public AudioSource MushEffect;
    public AudioSource BUGDAY;
    public AudioSource UGUR;
    public GameObject DarkPANEL;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Mushroom"))
        {

            MushEffect.Play();

            DarkPANEL.SetActive(true);

        }

        if (collision.CompareTag("coins"))
        {
            BUGDAY.Play();

        }

        if (collision.CompareTag("UgurBocek"))
        {

            UGUR.Play();
        }

      

    }


}
