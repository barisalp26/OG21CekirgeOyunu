using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FallManager : MonoBehaviour
{
    public float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cekirge"))
        {
            other.GetComponent<PlayerManager>().GetDamage(damage);
            other.GetComponent<PlayerManager>().GetDamage(damage);
            other.GetComponent<PlayerManager>().GetDamage(damage);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
