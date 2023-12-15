using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public GameObject Panel;
    public GameObject IMGpanel;

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){

            if(SceneManager.GetActiveScene().buildIndex==1){

                Panel.SetActive(true);
                IMGpanel.SetActive(false);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
    
        }
    }
    public void closePanel()
    {
        Panel.SetActive(false);
    }

    public void openPanel()
    {
        Panel.SetActive(true);
    }

    public void previousPage(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
