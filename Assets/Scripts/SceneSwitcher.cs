using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }


    public void selectLevels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void returnHome()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void LifeAssessment()
    {
        SceneManager.LoadScene("Life Assessment");
    }

    public void WoksAssessment()
    {
        SceneManager.LoadScene("Work Assessment");
    }

    public void PhilosophyAssessment()
    {
        SceneManager.LoadScene("Philosophy Assessment");
    }



}


