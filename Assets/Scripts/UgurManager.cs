using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UgurManager : MonoBehaviour
{
    public GameObject ugurbocek;
    public GameObject karakter;
    
    // Start is called before the first frame update
    void Start()
    {
        //if (karakter.GetComponent<PlayerManager>().health3 == 1)
        //{
        //    gameObject.SetActive(false);
        //}
        //else
        //{
        //    Invoke("GetHeal", 20f);
        //}
        Invoke("GetHeal", 20f);
    }

    void GetHeal()
    {

        ugurbocek.SetActive(true);

        float rast = Random.Range(-2f, 2f);
        Instantiate(ugurbocek, new Vector3(rast, karakter.transform.position.y + 18, 0), Quaternion.identity);

        //gameObject.transform.position = new Vector3(rast, karakter.transform.position.y + 13, 0);

        //gameObject.SetActive(true);

        // Update is called once per frame
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.GetComponent<PlayerManager>().health3 == 1)
        //{
        //    gameObject.SetActive(false);
        //}
        if(other.CompareTag("cekirge") )
        {
            other.GetComponent<PlayerManager>().GetHealed();
            gameObject.SetActive(false);

        }
        else if (other.CompareTag("kozalakDestroy"))
        {
            gameObject.SetActive(false);
        }
         
    }
    void Update()
        {
        //if (karakter.GetComponent<PlayerManager>().canHeal==true)
        //{
        //    Invoke("GetHeal", 20f);
        //}
        }

}
