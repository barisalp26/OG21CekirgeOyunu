using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow2 : MonoBehaviour
{
    public Transform karakter;

    Transform bar;

    void Start()
    {
        bar = GameObject.Find("Cekirge").transform;
    }

    void Update()
    {
        transform.position = new Vector3(bar.position.x, bar.position.y, bar.position.z);
    }
}
