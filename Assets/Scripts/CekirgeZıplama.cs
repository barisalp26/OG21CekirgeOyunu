using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CekirgeZıplama : MonoBehaviour
{

    public Rigidbody2D rb;
    Animator playerAnmimator;
    bool onWall;
    int onWallControl;
    public float hareketHizi;
    public float speed = 5f;
    public float speed2 = 5f;
    int direction = 1;

    public Text scoreText;
    public Text scoreText1;

    public AudioSource Jump;


    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        playerAnmimator = GetComponent<Animator>();
        
    }
    private void Update()
    {

        Score();
        Score1();


        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.zero;
            FlipFace();
            rb.AddForce(new Vector2(speed2 * direction, speed), ForceMode2D.Impulse);
            if (onWallControl == 0)
            {
                onWall = false;
                playerAnmimator.SetBool("OnWall", onWall);
            }

            direction = (direction == 1) ? -1 : 1;

            Jump.Play();
            GetComponent<PlayerManager>().headSpin= false;
            playerAnmimator.SetBool("headSpin", GetComponent<PlayerManager>().headSpin = false);
        }


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Duvar"))
        {
            rb.velocity = Vector3.zero;
            rb.gravityScale = 0f;
            onWall = true;
            onWallControl = 1;
            playerAnmimator.SetBool("OnWall", onWall);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Duvar"))
        {
            rb.gravityScale = 1;
            onWallControl = 0;
            
        }
    }
    void FlipFace()
    {
        if (Time.timeScale==1) 
        {
        Vector3 tempLocalScale = transform.localScale;

        tempLocalScale.y *= -1f;

        transform.localScale = tempLocalScale;
        } 
        
    }

    void Score()
    {
        
        scoreText.text = ((int)transform.position.y) + "";

    }
    void Score1()
    {
        
        scoreText1.text = ((int)transform.position.y) + "";

    }



    // Start is called before the first frame update


    #region old
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {

    //        var joint = transform.GetComponents<FixedJoint2D>();
    //        //Debug.Log("Tıkalama");

    //        rb.AddForce(new Vector2(speed2 * direction, speed), ForceMode2D.Impulse);
    //        if (joint.Length > 0 && isConnection)
    //        {
    //            FlipFace();
    //            joint = transform.GetComponents<FixedJoint2D>();
    //            foreach (var j in joint)
    //            {
    //                print("test1");
    //                j.connectedBody = null;
    //                Destroy(GetComponent<FixedJoint2D>());
    //                StartCoroutine(waitBoolen());


    //            }
    //        }


    //        else
    //        {
    //            rb.velocity = Vector3.zero;
    //            rb.AddForce(new Vector2(speed2 * direction, speed), ForceMode2D.Impulse);
    //            StartCoroutine(waitBoolen());
    //            FlipFace();
    //        }

    //        direction = (direction == 1) ? -1 : 1;



    //    }
    //    IEnumerator waitBoolen()
    //    {
    //        isConnection = true;
    //        yield return new WaitForSeconds(1f);
    //        isConnection = false;
    //    }

    //}

    //void FlipFace()
    //{
    //    Vector3 tempLocalScale = transform.localScale;

    //    tempLocalScale.y *= -1f;


    //    transform.localScale = tempLocalScale;
    //}
    //void OnCollisionEnter2D(Collision2D c)
    //{
    //    if (c.gameObject.CompareTag("Duvar") && !isConnection)
    //    {
    //        //if(joint == null)
    //        //{
    //        //    //joint = gameObject.AddComponent<FixedJoint>();
    //        //    //joint.connectedBody = c.rigidbody;

    //        //    Debug.Log("asd" + transform.position);
    //        //}
    //        //else
    //        //{
    //        //    joint = null;
    //        //}
    //        joint = gameObject.AddComponent<FixedJoint2D>();
    //        joint.connectedBody = c.rigidbody;
    //        rb.velocity = Vector3.zero;
    //        isConnection = true;


    //        //HingeJoint2D myJoint = (HingeJoint2D)gameObject.AddComponent("HingeJoint2D");
    //    }




    //}

    #endregion

}

