using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Manager : MonoBehaviour
{

    public static Player_Manager instance;
    public int levelsCompleted = 0; //DONT FORGET TO IMPLEMENT SAVE
    public int totalScore = 0; //Dont forget to implement save
    /*
    Player_Manager.instance.levelsCompleted = 1; // Change the value as needed
    Player_Manager.instance.totalScore = 100;   // Change the value as needed
    */
    private void Awake()
    {
        // Ensure there is only one instance of the GameManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeScore(int newscore)
    {
        totalScore=newscore;
    }
    public void levelscompleted()
    {
        levelsCompleted++;
    }
    public void resetProgress()
    {
        levelsCompleted=0;
        totalScore=0;
        
    }


   
}
