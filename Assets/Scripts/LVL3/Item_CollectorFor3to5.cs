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
        else if(collision.CompareTag("HiddenBomb"))
        {
            
            bombSoundEffect.Play();
            StartCoroutine(HandleHiddenBomb2());
            // gameOverText.text = "Game Over!";
            // countdownScript.GameOver();
            

        }
        else if(collision.CompareTag("HiddenminusTimer"))
        {
            collectSoundEffect.Play();
            StartCoroutine(DelayedDestroy(collision.gameObject, 1f));
            StartCoroutine(HandleMinusTime2());
            //Destroy(collision.gameObject);
            

        }
        else if(collision.CompareTag("HiddenplusTimer"))
        {
            collectSoundEffect.Play();
            StartCoroutine(DelayedDestroy(collision.gameObject, 1f));
            StartCoroutine(HandlePlusTime2());
            
            

        }
        else if(collision.CompareTag("HiddenShoe"))
        {
            collectSoundEffect.Play();
            StartCoroutine(DelayedDestroy(collision.gameObject, 1f));
            StartCoroutine(HandleHiddenShoe2());
            
            
        }
        
       
    }


private IEnumerator DelayedDestroy(GameObject obj, float delay)
{
    yield return new WaitForSeconds(delay);
    Destroy(obj);
}



        private IEnumerator HandleHiddenBomb2()
{
    yield return new WaitForSeconds(1f); // Delay for 2 seconds
    gameOverText.text = "Game Over!";
    countdownScript.GameOver();
}
private IEnumerator HandleMinusTime2()
{
    yield return new WaitForSeconds(1f); 
    CountdownFor11N6.MinusTime -= 10;
    Debug.Log("MINUS 10 SEONDS");
    
}

private IEnumerator HandlePlusTime2()
{
    yield return new WaitForSeconds(1f); 
    CountdownFor11N6.AddedTime += 10;
    
}

private IEnumerator HandleHiddenShoe2()
{
    yield return new WaitForSeconds(1f); 
    
}
}
