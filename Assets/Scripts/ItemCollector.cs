using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
// Ito yung gamit kapag ang countdown ay magistart agad pag-open ng scene
    public Countdown countdownScript;
    
    
    public TextMeshProUGUI gameOverText;


    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private AudioSource bombSoundEffect;
    
    private void Start(){
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("plusTimer"))
        {
            collectSoundEffect.Play();
            Countdown.AddedTime += 10;
            Destroy(collision.gameObject);

        }
        else if(collision.CompareTag("minusTimer"))
        {
            collectSoundEffect.Play();
            Countdown.MinusTime -= 10;
            Destroy(collision.gameObject);

        }
        else if(collision.CompareTag("Bomb"))
        {
            bombSoundEffect.Play();
            gameOverText.text = "Game Over!";
            countdownScript.GameOver();
            

        }
        else if(collision.CompareTag("Vegetables"))
        {
            collectSoundEffect.Play();
            
        }
        else if(collision.CompareTag("Book"))
        {
            //collectSoundEffect.Play();
            
        }
        else if(collision.CompareTag("Shoe"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
        }
        
    }

    
}
