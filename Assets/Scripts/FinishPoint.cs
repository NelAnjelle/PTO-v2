using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{


public FadeTransition fadeTransition; // Reference to the FadeTransition script

private int currentSceneInt;
private int nextLevelInt;

private void Start(){

string currentSceneName = SceneManager.GetActiveScene().name;


string[] words = currentSceneName.Split(' ');

if (words.Length >= 2 && int.TryParse(words[words.Length - 1], out currentSceneInt))
        {
            Debug.Log("Extracted Int Value: " + currentSceneInt);
            nextLevelInt = currentSceneInt+1;

        }
        else
        {
            Debug.LogError("Failed to extract int value from the string.");
        }

}

void Update()
    {
       
    }


   private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Level Complete");
            
            NextLevel();
           
            

        }
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        string nextLevelName = "Level "+ nextLevelInt;
        PlayerPrefs.SetInt("UnlockedLevel", nextLevelInt);
        Debug.Log("Lvl UNLOCKED: " + PlayerPrefs.GetInt("UnlockedLevel"));
        PlayerPrefs.Save();

        fadeTransition.LoadSceneWithFade(nextLevelName);
        //SceneManager.LoadScene(nextLevelName);

    }

    
    public void unlockNextLVL()
    {
        string nextLevelName = "Level "+ nextLevelInt;
        PlayerPrefs.SetInt("UnlockedLevel", nextLevelInt);
        Debug.Log("Lvl UNLOCKED: " + PlayerPrefs.GetInt("UnlockedLevel"));
        PlayerPrefs.Save();
    }

}
