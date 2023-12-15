using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sister : MonoBehaviour
{
    
    public string sister_Name;
    
    public string sister_Reply;
    
    public bool playerInSisterRange;

    bool isCorrect;

    public GameObject QuestionPanel;

    public TextMeshProUGUI TMP_sisterName;
    public TextMeshProUGUI TMP_sisterReply;


   

   void Start()
    {
        
    }
    

    void OnTriggerEnter2D(Collider2D other4)
    {
        if(other4.CompareTag("Player"))
        {
            playerInSisterRange = true;

        }
    }


    private void OnTriggerExit2D(Collider2D other4)
    {
        if(other4.CompareTag("Player"))
        {
            playerInSisterRange = false;
            QuestionPanel.SetActive(false);
            
        }
    }

    public void OpenQuestionPanel()
    {
        if(playerInSisterRange==true)
        {
            QuestionPanel.SetActive(true);
            TMP_sisterName.text = sister_Name;
            TMP_sisterReply.text  = sister_Reply;
            Level2Handler.selected_sister_Name = sister_Name;
            
        }

        

    }


    
}
