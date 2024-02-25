using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2Handler : MonoBehaviour
{

    public GameObject gameOverMenu;
    public GameObject UI;

    public AudioSource correctSound;
    public AudioSource wrongSound;
    public static string selected_sister_Name;
    public static int trial_Remaining;
    public GameObject resultPanel;
    public GameObject QandAPanel;
    public TextMeshProUGUI TMP_trialRemaining;
    public TextMeshProUGUI TMP_result;

    public GameObject Barrier;

    //public Countdown countdownScript;
   


    void Start()
    {
        Time.timeScale = 1f;
        trial_Remaining = 3;
        selected_sister_Name = " ";
        
        
    }
    
    void Update()
    {
        
        if(trial_Remaining==0)
        {
            GameOver();
           // countdownScript.GameOver();
        }else{
            //pag wala ito, pag nirestart yung game, nagigiging timescale = 0;
            // Time.timeScale = 1f;
            // PauseMenu.isPaused = false;
        }

        
    }

    // function for True butoon
   public void selectSister()
   {
    resultPanel.SetActive(true);
    QandAPanel.SetActive(false);

    if(selected_sister_Name == "Victorina"){
    correctSound.Play();
    Barrier.SetActive(false);
    TMP_trialRemaining.text = "Trial Remaining: " + trial_Remaining.ToString();
    TMP_result.text = "Correct!";
    Debug.Log(selected_sister_Name);
    }
    else
    {
    wrongSound.Play();
    trial_Remaining = trial_Remaining-1;
    TMP_trialRemaining.text = "Trial Remaining: " + trial_Remaining.ToString();
    TMP_result.text = "Wrong!";
    }
    

   }

       // function for False butoon
   public void selectSister2()
   {
    resultPanel.SetActive(true);
    QandAPanel.SetActive(false);

    if(selected_sister_Name != "Victorina"){
    correctSound.Play();
    //Barrier.SetActive(false);
    TMP_trialRemaining.text = "Trial Remaining: " + trial_Remaining.ToString();
    TMP_result.text = "Correct!";
    Debug.Log(selected_sister_Name);
    }
    else
    {
    wrongSound.Play();
    trial_Remaining = trial_Remaining-1;
    TMP_trialRemaining.text = "Trial Remaining: " + trial_Remaining.ToString();
    TMP_result.text = "Wrong!";
    }
    

   }


   public void GameOver()
    {
        SoundEffects.isGameOver=true;
        gameOverMenu.SetActive(true);
        UI.SetActive(false);
        
        Time.timeScale = 0f;
        Debug.Log(trial_Remaining);
        
        
    }

}
