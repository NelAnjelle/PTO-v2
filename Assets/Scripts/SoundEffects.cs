using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    
    public static bool isGameOver;
    bool isGOSEplayed;

    public AudioSource GameOverSound;
    
    // Start is called before the first frame update
    void Start()
    {
        
        isGameOver=false;
        isGOSEplayed = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(isGameOver==true && isGOSEplayed==false){
            GameOverSound.Play();
            isGOSEplayed = true;
            
        }

        
    }

    
}
