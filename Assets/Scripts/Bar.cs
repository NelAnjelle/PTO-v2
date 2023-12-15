using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour
{
    public GameObject bar;
    public int time;
    


    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
        
        
    }


    public void AnimateBar(){
        LeanTween.scaleX(bar,1,time).setOnComplete(Loading);
    }

     public void LoadHome(string sceneName = "HomeScreen")
    {
        
        SceneManager.LoadScene(sceneName);
    }

    void Loading(){

        if (SharedData.destination == ""){
            LoadHome();
        }
        else if (SharedData.destination == "LifeAndWorksOfOrata"){
            SceneManager.LoadScene("LifeAndWorksOfOrata");

        }
    }

}
public static class SharedData
{
    //initial value
    public static string destination = "";

}

