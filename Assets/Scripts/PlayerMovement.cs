using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Animator animator;
    public Joystick joystick; // Reference to the joystick prefab

    void Start()
    {
        speed = 3;
        Debug.Log("is paused: "+PauseMenu.isPaused );
            Debug.Log("Is playing: "+ Intro.startPlaying);
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if(PauseMenu.isPaused==false && Intro.startPlaying==true){
            
        // Get joystick input values from the joystick prefab
        float joystickInputX = joystick.Horizontal;
        float joystickInputY = joystick.Vertical;
        

        UpdateAnimationAndMove(joystickInputX, joystickInputY);
        }
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
}