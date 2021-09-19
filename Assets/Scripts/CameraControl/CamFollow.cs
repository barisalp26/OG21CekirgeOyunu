using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private Transform player;
   
    public float smoothX;
   
    public float smoothY;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Start()
    {

        player = GameObject.Find("Cekirge").transform;

    }

    void LateUpdate()
    {

        float posX = Mathf.MoveTowards(transform.position.x, player.position.x, smoothX);

        float posY = Mathf.MoveTowards(transform.position.y, player.position.y, smoothY);

        transform.position = new Vector3(Mathf.Clamp(posX,minX,maxX), Mathf.Clamp(posY,minY,maxY), transform.position.z);



    }

}
