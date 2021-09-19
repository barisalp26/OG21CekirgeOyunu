using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public float damage=1;
    public float health;
    //GameObject gameObject;

    public Slider slider;
    bool colliderBusy = false;
    bool dead = false;
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cekirge")&& !colliderBusy)
        {
            colliderBusy = true;
            other.GetComponent<PlayerManager>().GetDamage(damage);
            gameObject.SetActive(false);

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
        }
    }


}
