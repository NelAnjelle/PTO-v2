using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;
    public Button[] categoryBTN;
    public GameObject assessmentBTN;
    bool level15IsComplete;
    public FadeTransition fadeTransition; // Reference to the FadeTransition script

    private void Awake()
    {
        Debug.Log("Started");

        int unluckedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i<buttons.Length; i++)
        {
           
            buttons[i].interactable = false;
        }

        for (int i = 0; i<unluckedLevel; i++)
        {
            if(unluckedLevel==16){
                // pag unlucked level == 16, ibig sabihhin nacomplete na yung level 15
                level15IsComplete = true;
                unluckedLevel-=1;
            }
            Debug.Log("Level unlocked: " + unluckedLevel);
            buttons[i].interactable = true;
        }

        //Debug.Log("Level 15 is complete: "+level15IsComplete);

       if(level15IsComplete==true)
       {
        assessmentBTN.SetActive(true);
       }

    }

    public void OpenLevel(int levelId)
    {
        string levelName = "Level " + levelId;
        fadeTransition.LoadSceneWithFade(levelName);
        //SceneManager.LoadScene(levelName);

    }
}
