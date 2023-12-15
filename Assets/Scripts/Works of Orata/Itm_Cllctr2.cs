using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Itm_Cllctr2 : MonoBehaviour
{
    // Ito yung gamit kapag ang countdown ay magistart agad pag-open ng scene & Limited sa circle ang vision

    public Countdown countdownScript;
    public TextMeshProUGUI gameOverText;

    public GameObject Circle;
    
     public Vector2 scaleToAdd = new Vector2(0.5f, 0.5f);

    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private AudioSource bombSoundEffect;
    
    private void Start(){
        Vector3 originalScale = Circle.transform.localScale;
        
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
            collectSoundEffect.Play();
            
        }
        else if(collision.CompareTag("Shoe"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
        }
        else if(collision.CompareTag("Torch"))
        {
           
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            Circle.transform.localScale = new Vector3(
                Circle.transform.localScale.x + scaleToAdd.x,
                Circle.transform.localScale.y + scaleToAdd.y,
                Circle.transform.localScale.z
            );
            
        }
        else if(collision.CompareTag("enemy"))
        {
            bombSoundEffect.Play();
            gameOverText.text = "Game Over!";
            countdownScript.GameOver();
            

        }else if(collision.CompareTag("Zoom"))
        {
            collectSoundEffect.Play();
            
        }
       
    }

    
}
