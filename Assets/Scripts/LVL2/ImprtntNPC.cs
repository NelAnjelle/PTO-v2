using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImprtntNPC : MonoBehaviour
{

    [SerializeField]
private AudioSource NumerianaTTS; // Reference to the AudioSource
    private bool SoundhasPlayed = false;

    public bool playerInImpNPCRange;
    bool isTalked;
    public GameObject Obstacle;
    public GameObject dialogBox;
    public GameObject Indictr;
    public TextMeshProUGUI Convo;

    public string convoText;


    // Start is called before the first frame update
    void Start()
    {
        
        isTalked=false;
        if (NumerianaTTS == null)
        {
            Debug.LogError("No AudioSource found on this GameObject!");
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other2)
    {
        if(other2.CompareTag("Player"))
        {
            playerInImpNPCRange = true;
        
        }
    }

    private void OnTriggerExit2D(Collider2D other2)
    {
        if(other2.CompareTag("Player"))
        {

            playerInImpNPCRange = false;
            dialogBox.SetActive(false);
            if(isTalked==true){
                Obstacle.SetActive(false);
            }
            
            
        }
    }

    public void OpenDialog(){

        if(playerInImpNPCRange)
        {
    
                 if(dialogBox.activeInHierarchy)
                 {
                    // dialogBox.SetActive(false);
                 }else{
                    
                    isTalked=true;
                    Time.timeScale = 0f;
                     dialogBox.SetActive(true);
                
                     Convo.text = convoText;
                     Indictr.SetActive(true);


                     if (NumerianaTTS != null)
                     {
                        NumerianaTTS.Play(); // Play the sound
                        SoundhasPlayed = true;  // Prevent it from playing again
                    }

                   
                    
                 }
        }
    }

    public void CloseDialog()
    {
        if(playerInImpNPCRange)
        {
    
                 if(dialogBox.activeInHierarchy)
                 {
                    Time.timeScale = 1f;
                     dialogBox.SetActive(false);
                     Indictr.SetActive(false);

                 }else{
                     //dialogBox.SetActive(true);
                    // dialogText2.text = dialog;
                 }
        }
    }




   
}
