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
        else if(collision.CompareTag("HiddenBomb"))
        {
            
            bombSoundEffect.Play();
            StartCoroutine(HandleHiddenBomb());
            

        }
        else if(collision.CompareTag("HiddenminusTimer"))
        {
            collectSoundEffect.Play();
            StartCoroutine(DelayedDestroy(collision.gameObject, 1f));
            StartCoroutine(HandleMinusTime());
            
            

        }
        else if(collision.CompareTag("HiddenplusTimer"))
        {
            collectSoundEffect.Play();
            StartCoroutine(DelayedDestroy(collision.gameObject, 1f));
            StartCoroutine(HandlePlusTime());
            
            

        }
        else if(collision.CompareTag("HiddenShoe"))
        {
            collectSoundEffect.Play();
            StartCoroutine(DelayedDestroy(collision.gameObject, 1f));
            StartCoroutine(HandleHiddenShoe());
            
            
        }
        
        
    }

private IEnumerator DelayedDestroy(GameObject obj, float delay)
{
    yield return new WaitForSeconds(delay);
    Destroy(obj);
}


    private IEnumerator HandleHiddenBomb()
{
    yield return new WaitForSeconds(1f); 
    gameOverText.text = "Game Over!";
    countdownScript.GameOver();
}

private IEnumerator HandleMinusTime()
{
    yield return new WaitForSeconds(1f); 
    Countdown.MinusTime -= 10;
    
}

private IEnumerator HandlePlusTime()
{
    yield return new WaitForSeconds(1f); 
    Countdown.AddedTime += 10;
    
}

private IEnumerator HandleHiddenShoe()
{
    yield return new WaitForSeconds(1f); 
    
}

    
}
