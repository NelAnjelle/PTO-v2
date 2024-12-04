using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CountdownFor11N6 : MonoBehaviour
{

     public AudioSource ClockTickingSound;
     bool isTickingSoundPlayed = false;
     public GameObject ClockSEHolder;

    // start countdown pagkasara ng panel
    public GameObject gameOverMenu;
    public GameObject UI;

    public GameObject Reminder;


    public static int AddedTime;
    public static int MinusTime;
    
    public static float remainingTime;
    
    public float TimerSecs = 00;
    

    public TextMeshProUGUI textMins;
    public TextMeshProUGUI textColon;
    public TextMeshProUGUI textSecs;
    public TextMeshProUGUI gameOverText;


    private string levelName;
    
    


    // Start is called before the first frame update
    void Start()
    {
        AddedTime=0;
        
        // if(Intro.hasRunDemo){
        //     Intro.startPlaying=true;
        // } 
        
        

        levelName = SceneManager.GetActiveScene().name;
        //textSecs.text = TimerSecs.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if(!Reminder.activeSelf){
        //float remainingTime;

        TimerSecs -= Time.deltaTime;
        remainingTime=TimerSecs+AddedTime+MinusTime;
        //Debug.Log("Time remaining: "+ remainingTime);
        
        
        
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        //for clock sound effects
        if (remainingTime < 10 && remainingTime > 0 && !isTickingSoundPlayed)
    {
        ClockTickingSound.Play();
        isTickingSoundPlayed = true;
    }

    if (remainingTime <= 0)
    {
        ClockTickingSound.Stop();
        isTickingSoundPlayed = false; // Reset the flag when the countdown ends
    }
        

        
        if(remainingTime>0)
        {

            if(minutes<=9){
                textMins.text = "0" + Mathf.Round(minutes).ToString();
            }else{
                textMins.text = Mathf.Round(minutes).ToString();
            }


            if(seconds <= 9){
                
                textSecs.text = "0" + Mathf.Round(seconds).ToString();
                // magdadag ng 0 sa tabi ng number
            if(seconds <  11 && minutes==0)
            {
                
                textMins.color = Color.red;
                textColon.color = Color.red;
                textSecs.color = Color.red;
                textSecs.text ="0" + Mathf.Round(seconds).ToString();
                //magpapalit ng kulay kapag 5 secs na lang natira
                
            }

            }else{
                textSecs.text = Mathf.Round(seconds).ToString();
            }
        }
        else{
            
            textMins.text = "00";
            textSecs.text = "00";
            gameOverText.text = "Times Up!\nGame Over";
            GameOver();
            
        }
        
    }
    }

    public void GameOver()
    {
        SoundEffects.isGameOver=true;
        gameOverMenu.SetActive(true);
        UI.SetActive(false);
        
        Time.timeScale = 0f;
        PauseMenu.isPaused = true;
        
    }

    public void RestartGame()
    {
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.isPaused = false;
        SceneManager.LoadScene(levelName);

        //Pag tinanggal ko to 'di gagana restart button sa game over panel
        //ah kailangan pala i-reset yung value ng timer
        TimerSecs = 40;
        
    }

    public void QuitLevel()
    {
        
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.isPaused = false;
        //Pag tinanggal ko to 'di gagana restart button sa game over panel
        //ah kailangan pala i-reset yung value ng timer
        TimerSecs = 40;
        
    }

    
}
