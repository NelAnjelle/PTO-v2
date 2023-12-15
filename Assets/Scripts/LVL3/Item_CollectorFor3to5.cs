using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item_CollectorFor3to5 : MonoBehaviour
{
    public CountdownFor11N6 countdownScript;
    public TextMeshProUGUI gameOverText;

    
    
     

    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private AudioSource bombSoundEffect;
    
    private void Start(){}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("plusTimer"))
        {
            collectSoundEffect.Play();
            CountdownFor11N6.AddedTime += 10;
            Destroy(collision.gameObject);

        }
        else if(collision.CompareTag("minusTimer"))
        {
            collectSoundEffect.Play();
            CountdownFor11N6.MinusTime -= 10;
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
