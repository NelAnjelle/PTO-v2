using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    
    string currentSceneName;

    public FinishPoint finishPoint; //Reference to the FinishPoint script
    public static bool isLevelComplete;
    public int minTimeFor3Stars;
    public int minTimeFor2Stars;
    public int minTimeFor1Star;

    public float timeFinished;
    

    public GameObject LvlCmpltPanel;
    public GameObject UI;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    [SerializeField] private AudioSource LvlCompletedSoundEffect;

   
    void Start()
    {
        isLevelComplete=false;
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other3)
    {
        if(other3.CompareTag("Player"))
        {
            Debug.Log("Level Complete");
            LvlCompletedSoundEffect.Play();

            CalculateStars();
            finishPoint.unlockNextLVL();

        }
    }

    public void CalculateStars(){

        isLevelComplete = true;
        Time.timeScale = 0f;

        if (currentSceneName == "Level 3" || currentSceneName == "Level 4" || currentSceneName == "Level 5" || currentSceneName == "Level 6" || currentSceneName == "Level 8" || currentSceneName == "Level 11" )
        {
            timeFinished=CountdownFor11N6.remainingTime;
        }
        else{
        timeFinished=Countdown.remainingTime;
        }
        Debug.Log("CURRENT SCENE: "+currentSceneName);
        Debug.Log("Time Finished: "+timeFinished);

        LvlCmpltPanel.SetActive(true);
        UI.SetActive(false);
        
        if(timeFinished>minTimeFor3Stars){
            star3.SetActive(true);
            star2.SetActive(true);
            star1.SetActive(true);
        }
        else if(timeFinished<minTimeFor3Stars && timeFinished >= minTimeFor2Stars){
            star2.SetActive(true);
            star1.SetActive(true);
        }
        else if(timeFinished<minTimeFor2Stars && timeFinished >= minTimeFor1Star){
            
            star1.SetActive(true);
        }
        
    }

    

}
