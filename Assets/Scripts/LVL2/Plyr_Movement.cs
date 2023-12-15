using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyr_Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Animator animator;
    public Joystick joystick; 
    void Start()
    {
        speed = 3;
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get joystick input values from the joystick prefab
        float joystickInputX = joystick.Horizontal;
        float joystickInputY = joystick.Vertical;


        UpdateAnimationAndMove(joystickInputX, joystickInputY);
        
    }

    void UpdateAnimationAndMove(float moveX, float moveY)
    {
        Vector3 movement = new Vector3(moveX, moveY, 0f);
        if (movement != Vector3.zero)
        {
            MoveCharacter(movement);
            animator.SetFloat("moveX", movement.x);
            animator.SetFloat("moveY", movement.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter(Vector3 movement)
    {
        myRigidbody.MovePosition(
            transform.position + movement * speed * Time.deltaTime
        );
    }

    private void OnTriggerEnter2D(Collider2D collisionss)
    {
        if(collisionss.CompareTag("Shoe"))
        {
            speed+=0.7f;
            
        }
    }

    
}