using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pot : MonoBehaviour
{

    public bool playerInPotRange;
    public GameObject potContains;
    private Animator anim;
    Transform potPosition;

    [SerializeField] private AudioSource breakSounds;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //potContains.SetActive(false);
        potPosition = transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInPotRange = true;
        
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInPotRange = false;
        
        }
    }

    

    public void Smash()
    {
        if(playerInPotRange==true)
        {
        breakSounds.Play();
        anim.SetBool("smash", true);
        if(potContains !=null){
            potContains.transform.position = potPosition.position;
            potContains.SetActive(true);
        }
        StartCoroutine(breakCo());
        // this.gameObject.SetActive(false);
        playerInPotRange = false;
        
        }
    }

    IEnumerator breakCo()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
    }

}
