using UnityEngine;

public class FPlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Animator animator;
    public Joystick joystick; // Reference to the joystick prefab
    public GameObject FCharacter;
    public GameObject FJoystick;
    public GameObject MCharacter;
    public GameObject MJoystick;
    private string gender;

    void Start()
    {

        gender = PlayerPrefs.GetString("SelectedGender");
        if(gender=="Boy"){
            FCharacter.SetActive(false);
            FJoystick.SetActive(false);
        }
        else
        {
            MCharacter.SetActive(false);
            MJoystick.SetActive(false);
        }

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
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void MoveCharacter(Vector3 movement)
    {
        myRigidbody.MovePosition(
            transform.position + movement * speed * Time.deltaTime
        );
    }
}
