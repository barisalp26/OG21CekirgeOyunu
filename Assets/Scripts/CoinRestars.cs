using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRestars : MonoBehaviour
{

    void Start()
    {
        CircleCollider2D circle = GetComponent<CircleCollider2D>();
        circle.enabled = true;
        circle.isTrigger = true;
    }

}
