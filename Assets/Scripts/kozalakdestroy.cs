using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kozalakdestroy : MonoBehaviour
{
    public GameObject kozalak,bukalemunR, bukalemunL, StickWallR, StickWallL,mantar,atesbocek,ugurbocek;
    public GameObject karakter;
    [SerializeField]
    float fallSpeed = 7f;


    [SerializeField]
    GameObject coinPrefab;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "kozalak")
    //    {
    //        collision.gameObject.SetActive(false);
    //        StartCoroutine(SpawnKozalak(collision.gameObject));

    //    }

    //}
    private void Start()
    {
        InvokeRepeating("SpawnKozalak", 5f, fallSpeed);
        StartCoroutine(speedDecrease());
    }

    void SpawnKozalak()
    {
        kozalak.SetActive(true);

        float rast = Random.Range(-2f, 2f);
        //gameObject.transform.position = new Vector3(rast, karakter.transform.position.y + 13, 0);

        //gameObject.SetActive(true);

        Instantiate(kozalak, new Vector3(rast, karakter.transform.position.y+13, 0), Quaternion.identity);
       
    }
    IEnumerator speedDecrease()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            if (fallSpeed >= 6f)
            {
                fallSpeed -= 0.015f;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggergirdi");
        if (collision.CompareTag("coins"))
        {
            Debug.Log("triggerifiçinegirdi");
            coinPrefab.SetActive(false);
            //Destroy(coinPrefab);
            
            StartCoroutine(coinSpawner());
        }
        if (collision.CompareTag("bukalemunR"))
        {
            bukalemunR.SetActive(false);
        }
        if (collision.CompareTag("bukalemunL"))
        {
            bukalemunL.SetActive(false);
        }
        if (collision.CompareTag("stickWallR"))
        {
            StickWallR.SetActive(false);
        }
        if (collision.CompareTag("stickWallL"))
        {
            StickWallL.SetActive(false);
        }
        if (collision.CompareTag("Mushroom"))
        {
            mantar.SetActive(false);
        }
        if (collision.CompareTag("atesbocek"))
        {
            atesbocek.SetActive(false);
        }
        if (collision.CompareTag("UgurBocek"))
        {
            ugurbocek.SetActive(false);
        }

    }
    IEnumerator coinSpawner()
    {
        yield return new WaitForSeconds(3f);
        coinPrefab.SetActive(true);
        float rast = Random.Range(-2f, 2f);
        Instantiate(coinPrefab.transform, new Vector3(rast, karakter.transform.position.y + 13, 0), Quaternion.identity);
        



    }
}
