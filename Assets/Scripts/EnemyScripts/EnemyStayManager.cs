using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStayManager : MonoBehaviour
{
    public float damage = 1;
    public float health;
    //GameObject gameObject;


    bool colliderBusy = false;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cekirge") && !colliderBusy)
        {
            colliderBusy = true;

            //Invoke("giveDamage", 1f);
            //void giveDamage()
            //{
            //       other.GetComponent<PlayerManager>().GetDamage(damage);
            //}

            other.GetComponent<PlayerManager>().GetDamage(damage);

        }
        
        if (other.CompareTag("kozalakDestroy"))
        {
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("cekirge") && !colliderBusy)
        {
            colliderBusy = false;
            //gameObject.SetActive(true);
            other.isTrigger = true;
        }
    }
}
