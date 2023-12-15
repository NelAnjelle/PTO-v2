using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutPanelScript : MonoBehaviour
{

    
    public GameObject AboutPanel;

    // Start is called before the first frame update
    void Start()
    {
       
       if(!PlayerPrefs.HasKey("AboutPanelShown"))
       {
        AboutPanel.SetActive(true);
        PlayerPrefs.SetInt("AboutPanelShown", 1);
        PlayerPrefs.Save();
       }
       else{
        AboutPanel.SetActive(false);
       }
    }

   
}
