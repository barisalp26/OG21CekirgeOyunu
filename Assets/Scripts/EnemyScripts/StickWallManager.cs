using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickWallManager : MonoBehaviour
{
    public GameObject stickWall;
    public GameObject karakter;
    // Start is called before the first frame update
    private void Start()
    {
        Invoke("SpawnStickWall", 5f);
    }

    void SpawnStickWall()
    {
        stickWall.SetActive(true);


            Instantiate(stickWall, new Vector3(-1.9f, karakter.transform.position.y + 18, 0), Quaternion.identity);

        //gameObject.transform.position = new Vector3(rast, karakter.transform.position.y + 13, 0);

        //gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
