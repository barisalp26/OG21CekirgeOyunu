using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    
   
    public int highScore;
    public int instantGold;
    public int totalGold;

    EasyFileSave myFile;
    
    void Awake()
    {
        if (Instance == null)
        {
            
            Instance = this;
            StartProcess();
            
        }
        
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int InstantGold
    {
        get
        {
            return instantGold;
        }
        set
        {
            totalGold = value;
            //GameObject.Find("GoldText").GetComponent<Text>().text = "  " + totalGold.ToString();
        }
    }

     void StartProcess()
     {
        myFile = new EasyFileSave();
        LoadData();
     }

    public void SaveData()
    {
        totalGold = totalGold+instantGold;
        

        myFile.Add("totalGold", totalGold);
        myFile.Save();
    }

    public void LoadData()
    {
        if (myFile.Load())
        {
            totalGold = myFile.GetInt("totalGold");
        }
    }
}
