using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sign : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText2;
    public string dialog;
    public bool playerInRange;
    
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }

    public void OpenTrivia(){

        if(playerInRange)
        {
    
                 if(dialogBox.activeInHierarchy)
                 {
                    // dialogBox.SetActive(false);
                 }else{
                    Time.timeScale = 0f;
                     dialogBox.SetActive(true);
                     dialogText2.text = dialog;

                
                   
                 }
        }
    }

    public void CloseTrivia()
    {
        if(playerInRange)
        {
    
                 if(dialogBox.activeInHierarchy)
                 {
                    Time.timeScale = 1f;
                     dialogBox.SetActive(false);
                 }else{
                     //dialogBox.SetActive(true);
                    // dialogText2.text = dialog;
                 }
        }
    }


    

}


