using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesbocekManager : MonoBehaviour
{
    public GameObject karakter,blackScreen,atesbocek;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cekirge"))
        {
            other.GetComponent<PlayerManager>().See();
            atesbocek.SetActive(false);
        }
        
        if (other.CompareTag("kozalakDestroy"))
        {
            atesbocek.SetActive(false);
        }

    }
    //public void getEye()
    //{
    //    atesbocek.SetActive(true);

    //    float rast = Random.Range(-2f, 2f);
    //    Instantiate(gameObject, new Vector3(rast, karakter.transform.position.y + 10, 0), Quaternion.identity);
    //}

}
