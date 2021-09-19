using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BukalemunRight : MonoBehaviour
{
    public GameObject bukalemun;
    public GameObject karakter;
    // Start is called before the first frame update
    private void Start()
    {
        Invoke("BukalemunWall", 12f);
    }

    void BukalemunWall()
    {
        float rast = Random.Range(20f, 35f);
        bukalemun.SetActive(true);


        Instantiate(bukalemun, new Vector3(2f, karakter.transform.position.y + rast, 0), Quaternion.identity);

        //gameObject.transform.position = new Vector3(rast, karakter.transform.position.y + 13, 0);

        //gameObject.SetActive(true);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("kozalakDestroy"))
        {
            bukalemun.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
