using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AssesmentBtnMngr : MonoBehaviour
{

    public GameObject LifeBTN;
    public GameObject AchievementsBTN;
    public GameObject PhilosophyBTN;

    int categ1;
    int categ2;
    int categ3;

    public GameObject AssessTXT1;
    public GameObject AssessTXT2;
    public GameObject AssessTXT3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
         


        categ1 = PlayerPrefs.GetInt("Category1TotalStars");
        categ2 = PlayerPrefs.GetInt("Category2TotalStars");
        categ3 = PlayerPrefs.GetInt("Category3TotalStars");
        Debug.Log(categ1);


        
    }

    // Update is called once per frame
    void Update()
    {
        

        Button Lifebutton = LifeBTN.GetComponent<Button>();
         Button Achievementsbutton = AchievementsBTN.GetComponent<Button>();
         Button Philosophybutton = PhilosophyBTN.GetComponent<Button>();

        if (Lifebutton != null)
        {
            if(categ1<11){
                //Lifebutton.interactable = false;
                LifeBTN.SetActive(false);
                AssessTXT1.SetActive(true);
                
            }
            else{
                LifeBTN.SetActive(true);
                AssessTXT1.SetActive(false);
            }
            

            
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }

        if (Achievementsbutton != null)
        {
            if(categ2<11){
                //Achievementsbutton.interactable = false;
                AchievementsBTN.SetActive(false);
                AssessTXT2.SetActive(true);
            }
            else
            {
                AchievementsBTN.SetActive(true);
                AssessTXT2.SetActive(false);
            }
            
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }

        if (Philosophybutton != null)
        {
            if(categ3<11){
                //Philosophybutton.interactable = false;
                PhilosophyBTN.SetActive(false);
                AssessTXT3.SetActive(true);
            }
            else{
                PhilosophyBTN.SetActive(true);
                AssessTXT3.SetActive(false);
            }
            
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }
    }
}
