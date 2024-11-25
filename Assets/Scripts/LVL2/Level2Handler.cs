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
    
    public GameObject resultPanel;
    public GameObject QandAPanel;
    public TextMeshProUGUI TMP_trialRemaining; // tiral remaining -> notif na nagdededuct ng time
    public TextMeshProUGUI TMP_result;

    public GameObject Barrier;

    //public Countdown countdownScript;
   


    void Start()
    {
        Time.timeScale = 1f;
        selected_sister_Name = " ";
        
        
    }
    
    void Update()
    {
        
        
    }

    // function for True button
   public void selectSister()
   {
    resultPanel.SetActive(true);
    QandAPanel.SetActive(false);

    if(selected_sister_Name == "Victorina"){
    correctSound.Play();
    Barrier.SetActive(false);
    TMP_trialRemaining.text = "";
    TMP_result.text = "Correct!";
    Debug.Log(selected_sister_Name);
    }
    else
    {
    wrongSound.Play();
    Countdown.MinusTime-=10;
    
    TMP_trialRemaining.text = "-10 seconds";
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
    TMP_trialRemaining.text = "";
    TMP_result.text = "Correct!";
    Debug.Log(selected_sister_Name);
    }
    else
    {
    wrongSound.Play();
    TMP_trialRemaining.text = "-10 seconds";
    TMP_result.text = "Wrong!";
    }
    

   }


   public void GameOver()
    {
        SoundEffects.isGameOver=true;
        gameOverMenu.SetActive(true);
        UI.SetActive(false);
        
        Time.timeScale = 0f;
        
        
        
    }

}
