using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Envelope : MonoBehaviour
{
[SerializeField] private AudioSource TriviaSounds;
private bool SoundhasPlayed = false;

public bool playerInEnvelopeRange;
 bool isRead;

     public GameObject Barrier;
     public GameObject dialogBox;
     public GameObject envlp;
     public TextMeshProUGUI Trivia;
     public string trivia;
    
    // Start is called before the first frame update
    void Start()
    {
        if (TriviaSounds == null)
        {
            Debug.LogError("No AudioSource found on this GameObject!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInEnvelopeRange = true;
        
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {

            if(isRead==true){
                envlp.SetActive(false);
            }
            playerInEnvelopeRange = false;
            dialogBox.SetActive(false);
            
            
        }
    }

    public void OpenTrivia(){

        if(playerInEnvelopeRange)
        {
    
                 if(dialogBox.activeInHierarchy)
                 {
                    // dialogBox.SetActive(false);
                 }else{
                    Barrier.SetActive(false);
                     dialogBox.SetActive(true);
                     Time.timeScale = 0f;
                     isRead = true;
                     Trivia.text = trivia;


                     if (TriviaSounds != null)
                     {
                        TriviaSounds.Play(); // Play the sound
                        SoundhasPlayed = true;  // Prevent it from playing again
                    }
                    
                 }
        }
    }

    public void CloseTrivia()
    {
        if(playerInEnvelopeRange)
        {
    
                 if(dialogBox.activeInHierarchy)
                 {
                     dialogBox.SetActive(false);
                     Time.timeScale = 1f;
                     envlp.SetActive(false);

                 }else{
                     //dialogBox.SetActive(true);
                    // dialogText2.text = dialog;
                 }
        }
    }
}
