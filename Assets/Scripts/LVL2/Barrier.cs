using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Barrier : MonoBehaviour
{

    public GameObject NotificationPanel;
    public TextMeshProUGUI Notif;
    public string Notification;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other3)
    {
        if(other3.CompareTag("Player"))
        {
            NotificationPanel.SetActive(true);
            Notif.text = Notification;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other3)
    {
        if(other3.CompareTag("Player"))
        {
            NotificationPanel.SetActive(false);
        }
    }
}
