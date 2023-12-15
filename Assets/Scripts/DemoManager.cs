using System.Collections;
using UnityEngine;
using TMPro;

public class DemoManager : MonoBehaviour
{
    
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogText;
    public float dialogDuration = 5.0f; // Adjust this value for dialog display time
    public string[] dialogLines; // Array of dialog lines
    

    private void Start()
    {
        bool hasRunIntro = PlayerPrefs.GetInt("HasRunIntro", 0) == 1;


        if (!hasRunIntro)
       {
        StartCoroutine(ShowDialog());
       }
        
       
    }

    private IEnumerator ShowDialog()
    {

        dialogPanel.SetActive(true);
        foreach (string line in dialogLines)
        {
            dialogText.text = line;
            dialogPanel.SetActive(true);

            yield return new WaitForSeconds(dialogDuration);

            dialogPanel.SetActive(false);
            yield return new WaitForSeconds(1.0f); // Optional delay between lines
        }

        PlayerPrefs.SetInt("HasRunIntro", 1);
    }
}