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
        int ThisLevelStar =0;

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
            ThisLevelStar = 3;
            Debug.Log("This Level star: "+ThisLevelStar);
        }
        else if(timeFinished<minTimeFor3Stars && timeFinished >= minTimeFor2Stars){
            star2.SetActive(true);
            star1.SetActive(true);
             ThisLevelStar = 2;
            Debug.Log("This Level star: "+ThisLevelStar);
        }
        else if(timeFinished<minTimeFor2Stars && timeFinished >= minTimeFor1Star){
            
            star1.SetActive(true);
             ThisLevelStar = 1;
            Debug.Log("This Level star: "+ThisLevelStar);
        }





        if(currentSceneName=="Level 1"){
            Stars.Level1TotalStars = ThisLevelStar;
            Debug.Log("Level 1 stars:" + Stars.Level1TotalStars);
        }
        else if(currentSceneName=="Level 2"){
            Stars.Level2TotalStars = ThisLevelStar;
            Debug.Log("Level 2 stars:" + Stars.Level2TotalStars);
        }
        else if(currentSceneName=="Level 3"){
            Stars.Level3TotalStars = ThisLevelStar;
            Debug.Log("Level 3 stars:" + Stars.Level3TotalStars);
        }
        else if(currentSceneName=="Level 4"){
            Stars.Level4TotalStars = ThisLevelStar;
            Debug.Log("Level 4 stars:" + Stars.Level4TotalStars);
        }
        else if(currentSceneName=="Level 5"){
            Stars.Level5TotalStars = ThisLevelStar;
            Debug.Log("Level 5 stars:" + Stars.Level5TotalStars);
        }
        else if(currentSceneName=="Level 6"){
            Stars.Level6TotalStars = ThisLevelStar;
            Debug.Log("Level 6 stars:" + Stars.Level6TotalStars);
        }
        else if(currentSceneName=="Level 7"){
            Stars.Level7TotalStars = ThisLevelStar;
            Debug.Log("Level 7 stars:" + Stars.Level7TotalStars);
        }
        else if(currentSceneName=="Level 8"){
            Stars.Level8TotalStars = ThisLevelStar;
            Debug.Log("Level 8 stars:" + Stars.Level8TotalStars);
        }
        else if(currentSceneName=="Level 9"){
            Stars.Level9TotalStars = ThisLevelStar;
            Debug.Log("Level 9 stars:" + Stars.Level9TotalStars);
        }
        else if(currentSceneName=="Level 10"){
            Stars.Level10TotalStars = ThisLevelStar;
            Debug.Log("Level 10 stars:" + Stars.Level10TotalStars);
        }
        else if(currentSceneName=="Level 11"){
            Stars.Level11TotalStars = ThisLevelStar;
            Debug.Log("Level 11 stars:" + Stars.Level11TotalStars);
        }
        else if(currentSceneName=="Level 12"){
            Stars.Level12TotalStars = ThisLevelStar;
            Debug.Log("Level 12 stars:" + Stars.Level12TotalStars);
        }
        else if(currentSceneName=="Level 3"){
            Stars.Level13TotalStars = ThisLevelStar;
            Debug.Log("Level 13 stars:" + Stars.Level13TotalStars);
        }
        else if(currentSceneName=="Level 14"){
            Stars.Level14TotalStars = ThisLevelStar;
            Debug.Log("Level 14 stars:" + Stars.Level14TotalStars);
        }
        else if(currentSceneName=="Level 15"){
            Stars.Level15TotalStars = ThisLevelStar;
            Debug.Log("Level 15 stars:" + Stars.Level15TotalStars);
        }
        
    }

    

}
