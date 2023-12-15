using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Intro : MonoBehaviour
{
    public GameObject introBox;
    public GameObject pauseBTN;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;

    public static bool hasRunDemo;
    public static bool startPlaying = false;
     
    // Start is called before the first frame update
    void Start()
    {

        
        
         hasRunDemo = PlayerPrefs.GetInt("HasRunDemo", 0) == 1;
    

        if (!hasRunDemo)
         {
            
            introBox.SetActive(true);
            textComponent.text = string.Empty;
            StartIntro();
            PlayerPrefs.SetInt("HasRunDemo", 1);


            if(introBox.activeSelf){
            pauseBTN.SetActive(false);
        }

         }
    }

    // Update is called once per frame
    void Update()
    {



        
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                
            }
        }
        
        
    }

    void StartIntro()
    {
        index = 0;
        StartCoroutine(TypeLine());
        
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length -1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            introBox.SetActive(false);
            startPlaying = true;
            pauseBTN.SetActive(true);
        
            
        }
    }
}