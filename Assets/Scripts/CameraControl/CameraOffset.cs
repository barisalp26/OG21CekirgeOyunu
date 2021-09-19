using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffset : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 offset;
    public Transform Cekirge;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Cekirge.transform.position + offset, moveSpeed * Time.deltaTime);
    }


}
