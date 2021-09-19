using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MantarManager : MonoBehaviour
{
    bool colliderBusy = false;
    public GameObject atesbocek,karakter,blackScreen;
    int countdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cekirge") && !colliderBusy)
        {
            blackScreen.SetActive(true);
            atesbocek.SetActive(true);
            //atesbocek.GetComponent<AtesbocekManager>().getEye();
            colliderBusy = true;
           
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
    public void getPoisened()
    {
        gameObject.SetActive(true);

        float rast = Random.Range(-2f, 2f);
        Instantiate(gameObject, new Vector3(rast, karakter.transform.position.y + 30, 0), Quaternion.identity);
    }
}
