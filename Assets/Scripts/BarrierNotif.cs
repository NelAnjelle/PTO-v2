using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class BarrierNotif : MonoBehaviour
{
public GameObject Barrier;
public TextMeshProUGUI barrierNotifTMP;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerExit2D(Collider2D BarrierTrigger)
    {
        if(BarrierTrigger.CompareTag("Player"))
        {

            if(Barrier.activeSelf)
            {
                
            }else{
                barrierNotifTMP.gameObject.SetActive(true);
            }
            
            
        }
    }

}
