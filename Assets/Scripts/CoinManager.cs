using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    Transform Camera1;
    [SerializeField]
    GameObject coinPrefab;
    //public GameObject karakter;


    void Start()
    {
        Camera1 = GameObject.FindWithTag("MainCamera").transform;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coins"))
        {
           
            ScoreText.coinAncount += 1;
            DataManager.Instance.InstantGold++;
            
            coinPrefab.SetActive(false);
            Destroy(collision.gameObject);
            

            StartCoroutine(coinSpawner());
        }
    }
    IEnumerator coinSpawner()
    {
        yield return new WaitForSeconds(3f);
        coinPrefab.SetActive(true);
        float rast = Random.Range(-2f, 2f);
        Instantiate(coinPrefab.transform, new Vector3(rast, transform.position.y + 13, 0), Quaternion.identity);
        //Transform test=Instantiate(coinPrefab.transform, new Vector3(rast, Camera1.transform.position.y + 13, 0), Quaternion.identity);


    }

}
