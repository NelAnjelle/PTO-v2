using UnityEngine;
using UnityEngine.UI;

public class AssesmentBtnMngr : MonoBehaviour
{

    public GameObject LifeBTN;
    public GameObject AchievementsBTN;
    public GameObject PhilosophyBTN;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Button Lifebutton = LifeBTN.GetComponent<Button>();
         Button Achievementsbutton = AchievementsBTN.GetComponent<Button>();
         Button Philosophybutton = PhilosophyBTN.GetComponent<Button>();


        int categ1 = PlayerPrefs.GetInt("Category1TotalStars");
        int categ2 = PlayerPrefs.GetInt("Category2TotalStars");
        int categ3 = PlayerPrefs.GetInt("Category3TotalStars");
        Debug.Log(categ1);


        if (Lifebutton != null)
        {
            if(categ1<11){
                Lifebutton.interactable = false;
            }
            
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }

        if (Achievementsbutton != null)
        {
            if(categ2<11){
                Achievementsbutton.interactable = false;
            }
            
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }

        if (Philosophybutton != null)
        {
            if(categ3<11){
                Philosophybutton.interactable = false;
            }
            
        }
        else
        {
            Debug.LogError("No Button component found on the NextBtn GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
