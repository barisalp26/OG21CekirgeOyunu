using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YukseklikSkor : MonoBehaviour
{

    [SerializeField]
    public int score = 0;
    

    [SerializeField]
    Vector3 _lastPosition;

    // Use this for initialization
    void Start()
    {
        _lastPosition = this.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.position.y - _lastPosition.y) > 0)
            score++;

        _lastPosition = this.transform.position;


        if (this.transform.position.y > 500)
        {
            gameObject.CompareTag("Background2");
        }
    }

    void OnGUI()
    {
        GUILayout.Label("Score : " + score);
        
    }
}
