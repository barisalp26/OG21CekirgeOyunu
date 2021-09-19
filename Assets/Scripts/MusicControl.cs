using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    AudioSource sound_control;


    // Start is called before the first frame update
    void Start()
    {

        sound_control = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("soundStatus") == 1)
        {

            sound_control.mute = false;
        }
        else
        {

            sound_control.mute = true;

        }

    }


}
