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
    public GameObject NextLvlBtn;

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
            

        }
    }

    public void CalculateStars(){
        int ThisLevelStar =0;
        int ThisLevelHighscore= 0;

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
           
                finishPoint.unlockNextLVL();
            
            
        }
        else if(timeFinished<minTimeFor3Stars && timeFinished >= minTimeFor2Stars){
            star2.SetActive(true);
            star1.SetActive(true);
             ThisLevelStar = 2;
            Debug.Log("This Level star: "+ThisLevelStar);


            Button buttonNext = NextLvlBtn.GetComponent<Button>();
            if (buttonNext != null)
        {
            buttonNext.interactable = false;
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }

           
        }
        else if(timeFinished<minTimeFor2Stars && timeFinished >= minTimeFor1Star){
            
            star1.SetActive(true);
             ThisLevelStar = 1;
            Debug.Log("This Level star: "+ThisLevelStar);

            Button buttonNext = NextLvlBtn.GetComponent<Button>();
            if (buttonNext != null)
        {
            buttonNext.interactable = false;
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }

            
        }



       





        if(currentSceneName=="Level 1"){
            ThisLevelHighscore = Stars.Level1TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level1TotalStars = ThisLevelHighscore;
            Debug.Log("Level 1 stars:" + Stars.Level1TotalStars);
            PlayerPrefs.SetInt("Level1TotalStars", Stars.Level1TotalStars);

            
        }
        else if(currentSceneName=="Level 2"){
            ThisLevelHighscore = Stars.Level2TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level2TotalStars = ThisLevelHighscore;
            Debug.Log("Level 2 stars:" + Stars.Level2TotalStars);
            PlayerPrefs.SetInt("Level2TotalStars", Stars.Level2TotalStars);
        }
        else if(currentSceneName=="Level 3"){
            ThisLevelHighscore = Stars.Level3TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level3TotalStars = ThisLevelHighscore;
            Debug.Log("Level 3 stars:" + Stars.Level3TotalStars);
            PlayerPrefs.SetInt("Level3TotalStars", Stars.Level3TotalStars);
        }
        else if(currentSceneName=="Level 4"){
            ThisLevelHighscore = Stars.Level4TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level4TotalStars = ThisLevelHighscore;
            Debug.Log("Level 4 stars:" + Stars.Level4TotalStars);
            PlayerPrefs.SetInt("Level4TotalStars", Stars.Level4TotalStars);
        }
        else if(currentSceneName=="Level 5"){
            ThisLevelHighscore = Stars.Level5TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level5TotalStars = ThisLevelHighscore;
            Debug.Log("Level 5 stars:" + Stars.Level5TotalStars);
            PlayerPrefs.SetInt("Level5TotalStars", Stars.Level5TotalStars);
        }
        else if(currentSceneName=="Level 6"){
            ThisLevelHighscore = Stars.Level6TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level6TotalStars = ThisLevelHighscore;
            Debug.Log("Level 6 stars:" + Stars.Level6TotalStars);
            PlayerPrefs.SetInt("Level6TotalStars", Stars.Level6TotalStars);
        }
        else if(currentSceneName=="Level 7"){
            ThisLevelHighscore = Stars.Level7TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level7TotalStars = ThisLevelHighscore;
            Debug.Log("Level 7 stars:" + Stars.Level7TotalStars);
            PlayerPrefs.SetInt("Level7TotalStars", Stars.Level7TotalStars);
        }
        else if(currentSceneName=="Level 8"){
            ThisLevelHighscore = Stars.Level8TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level8TotalStars = ThisLevelHighscore;
            Debug.Log("Level 8 stars:" + Stars.Level8TotalStars);
            PlayerPrefs.SetInt("Level8TotalStars", Stars.Level8TotalStars);
        }
        else if(currentSceneName=="Level 9"){
            ThisLevelHighscore = Stars.Level9TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level9TotalStars = ThisLevelHighscore;
            Debug.Log("Level 9 stars:" + Stars.Level9TotalStars);
            PlayerPrefs.SetInt("Level9TotalStars", Stars.Level9TotalStars);
        }
        else if(currentSceneName=="Level 10"){
            ThisLevelHighscore = Stars.Level10TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level10TotalStars = ThisLevelHighscore;
            Debug.Log("Level 10 stars:" + Stars.Level10TotalStars);
            PlayerPrefs.SetInt("Level10TotalStars", Stars.Level10TotalStars);
        }
        else if(currentSceneName=="Level 11"){
            ThisLevelHighscore = Stars.Level11TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level11TotalStars = ThisLevelHighscore;
            Debug.Log("Level 11 stars:" + Stars.Level11TotalStars);
            PlayerPrefs.SetInt("Level11TotalStars", Stars.Level11TotalStars);
        }
        else if(currentSceneName=="Level 12"){
            ThisLevelHighscore = Stars.Level12TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level12TotalStars = ThisLevelHighscore;
            Debug.Log("Level 12 stars:" + Stars.Level12TotalStars);
            PlayerPrefs.SetInt("Level12TotalStars", Stars.Level12TotalStars);
        }
        else if(currentSceneName=="Level 13"){
            ThisLevelHighscore = Stars.Level13TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level13TotalStars = ThisLevelHighscore;
            Debug.Log("Level 13 stars:" + Stars.Level13TotalStars);
            PlayerPrefs.SetInt("Level13TotalStars", Stars.Level13TotalStars);
        }
        else if(currentSceneName=="Level 14"){
            ThisLevelHighscore = Stars.Level14TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level14TotalStars = ThisLevelHighscore;
            Debug.Log("Level 14 stars:" + Stars.Level14TotalStars);
            PlayerPrefs.SetInt("Level14TotalStars", Stars.Level14TotalStars);
        }
        else if(currentSceneName=="Level 15"){
            ThisLevelHighscore = Stars.Level15TotalStars;
            if (ThisLevelStar > ThisLevelHighscore){ThisLevelHighscore = ThisLevelStar;}

            Stars.Level15TotalStars = ThisLevelHighscore;
            Debug.Log("Level 15 stars:" + Stars.Level15TotalStars);
            PlayerPrefs.SetInt("Level15TotalStars", Stars.Level15TotalStars);
        }

        Stars.Categ1TotalStars = Stars.Level1TotalStars + Stars.Level2TotalStars + Stars.Level3TotalStars + Stars.Level4TotalStars + Stars.Level5TotalStars;
        //Debug.Log("Total stars Category 1: "+Stars.Categ1TotalStars);
        PlayerPrefs.SetInt("Category1TotalStars", Stars.Categ1TotalStars);
        Debug.Log("Saved Category 1 Total Stars in PlayerPrefs: " + PlayerPrefs.GetInt("Category1TotalStars"));

        Stars.Categ2TotalStars = Stars.Level6TotalStars + Stars.Level7TotalStars + Stars.Level8TotalStars + Stars.Level9TotalStars + Stars.Level10TotalStars;
        //Debug.Log("Total stars Category 2: "+Stars.Categ2TotalStars);
        PlayerPrefs.SetInt("Category2TotalStars", Stars.Categ2TotalStars);
        Debug.Log("Saved Category 2 Total Stars in PlayerPrefs: " + PlayerPrefs.GetInt("Category2TotalStars"));

        Stars.Categ3TotalStars = Stars.Level11TotalStars + Stars.Level12TotalStars + Stars.Level13TotalStars + Stars.Level14TotalStars + Stars.Level15TotalStars;
        //Debug.Log("Total stars Category 3: "+Stars.Categ3TotalStars);
        PlayerPrefs.SetInt("Category3TotalStars", Stars.Categ3TotalStars);
        Debug.Log("Saved Category 3 Total Stars in PlayerPrefs: " + PlayerPrefs.GetInt("Category3TotalStars"));


        PlayerPrefs.Save();
        
    }

    

}
