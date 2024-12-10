using UnityEngine;
using UnityEngine.UI;

public class GenderSelect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    string SelectedGender;
    public GameObject GenderPanel;
    bool HasGender;
    
    void Start()
    {

        
        SelectedGender = PlayerPrefs.GetString("SelectedGender", null);

        if (string.IsNullOrEmpty(SelectedGender))
        {
            // Show the gender selection panel if no gender is selected
            GenderPanel.SetActive(true);
        }
        else
        {
            // Hide the panel and log the saved gender
            GenderPanel.SetActive(false);
            Debug.Log("Previously selected gender: " + SelectedGender);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }




public void IsBoy()
    {
        SetGender("Boy");
    }

    public void IsGirl()
    {
        SetGender("Girl");
    }

    private void SetGender(string gender)
    {
        SelectedGender = gender;
        Debug.Log("Player selected: " + gender);
        PlayerPrefs.SetString("SelectedGender", gender); // Save the selection
        PlayerPrefs.Save(); // Ensure the data is written to storage
        GenderPanel.SetActive(false); // Hide the panel
    }

}


