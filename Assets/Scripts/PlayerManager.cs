    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health, health2, health3;
    public bool dead = false;
    public bool canHeal = false;
    public GameObject gameOverScreen, inGameScreen, dataBoard, HasanObject, atesbocek, blackScreen2, blackScreen3, mantar;
    Rigidbody2D rb;
    public bool headSpin;
    Animator playerAnmimator;
    int HasanAbi = 0;
    int canSee = 2;

    public Slider slider, slider2, slider3;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        slider.maxValue = health;
        slider.value = health;
        slider2.maxValue = health2;
        slider2.value = health2;
        slider3.maxValue = health3;
        slider3.value = health3;
        playerAnmimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetDamage(float damage)
    {
        // Instantiate  kafa dönmesi
        //headSpin = true;
        //playerAnmimator.SetBool("headSpin", headSpin);

        if (health3 - damage >= 0)
        {
            health3 -= damage;
        }
        else if (health3 == 0 && health2 - damage >= 0)
        {
            health2 -= damage;
        }
        else if (health2 == 0 && health - damage >= 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        canHeal = true;
        slider3.value = health3;
        slider2.value = health2;
        slider.value = health;
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector2(0, -1f), ForceMode2D.Impulse);
        AmIDead();

        IEnumerator Wait(float sec)
        {
            sec = 3f;
            print("Hasar yedi");
            yield return new WaitForSeconds(sec);
        }


    }
    IEnumerator HasanSpawner()
    {
        yield return new WaitForSeconds(3f);
        HasanObject.SetActive(false);
    }
    public void GetHealed()
    {
        if (health3 == 1)
        {
            HasanAbi++;
            if (HasanAbi == 1)
            {
                HasanObject.SetActive(true);
                StartCoroutine(HasanSpawner());
                HasanAbi--;
            }
        }
        else if (health == 1 && health2 == 1)
        {
            health3++;

        }
        else if (health == 1 && health2 == 0)
        {
            health2++;
        }
        canHeal = false;
        slider3.value = health3;
        slider2.value = health2;
        slider.value = health;
    }
    public void AmIDead()
    {
        if (health <= 0)
        {
            dead = true;
            IAmDead();
        }
        //GameOver

    }
    public void IAmDead()
    {

        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        gameOverScreen.SetActive(true);

        DataManager.Instance.LoadData();
        dataBoard.transform.GetChild(5).GetComponent<Text>().text = DataManager.Instance.totalGold.ToString();
        dataBoard.SetActive(true);
    }
    public void See()
    {
        if (canSee == 2)
        {
            mantar.GetComponent<MantarManager>().blackScreen.SetActive(false);
            //blackScreen2.SetActive(true);
            //atesbocek.;
            //canSee++;
            //}else if (canSee == 3)
            //{
            //    blackScreen2.SetActive(false);
            //    blackScreen3.SetActive(true);
            //    atesbocek.GetComponent<AtesbocekManager>().getEye();
            //    canSee++;
            //}else if (canSee == 4)
            //{
            //    blackScreen3.SetActive(false);
            //    canSee = canSee - 2;
            //    atesbocek.SetActive(false);
            //    mantar.SetActive(true);
            //}
        }
    }
}

