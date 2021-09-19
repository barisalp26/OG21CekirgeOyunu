using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSIC : MonoBehaviour
{


    public GameObject sound_opened;
    public GameObject sound_closed;





    void Update()
    {

        if (PlayerPrefs.GetInt("soundStatus") == 1)
        {

            sound_opened.SetActive(true);
            sound_closed.SetActive(false);


        }
        else
        {

            sound_opened.SetActive(false);
            sound_closed.SetActive(true);

        }


    }


    public void sound_status(string status)
    {

        if (status == "opened")
        {

            sound_opened.SetActive(false);
            sound_closed.SetActive(true);
            PlayerPrefs.SetInt("soundStatus", 0);

        }
        else if (status == "closed")
        {

            sound_opened.SetActive(true);
            sound_closed.SetActive(false);
            PlayerPrefs.SetInt("soundStatus", 1);


        }

    }
}
