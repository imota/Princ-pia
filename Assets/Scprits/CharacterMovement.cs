using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    [HideInInspector]
    public bool jump = false;               // Condition for whether the player should jump.

    public Vector2 speed = new Vector2(7, 7); //Characters speed
    public float sensibility = 0.5f;    //Sensibility of the controller, from 0 to 1
    
    public bool move = true;

    private float inputX;
    private string jumpButton;
    private string jumpButton2;

    public double jumpDelay = 0.15;
    private double jumpTime = 0;

    [HideInInspector]
    public string MovementState;

    void Start()
    {
        MovementState = "Stop";
    }

    void Update()
    {
        //Retrieve the x-axis information
        inputX = Input.GetAxis("Horizontal");
        if (inputX < sensibility && inputX > -sensibility)
            inputX = 0;
        else
            inputX = inputX / Mathf.Abs(inputX); //returns +1 or -1

        //Retrieve the y-axis information
        jumpButton =  "w";
        jumpButton2 = "joystick button 4";

        bool grounded = true; //gameObject.GetComponent<CharacterScript>().isGrounded;

        // If the jump button is pressed and the player is grounded then the player should jump.
        if ((Input.GetKeyDown(jumpButton) || Input.GetKeyDown(jumpButton2)) && grounded)
            jump = true;

        if (jump) MovementState = "Jump";
        else if (grounded && inputX == 0) MovementState = "Stop";
        else if (grounded) MovementState = "Move";
        else MovementState = "Fall";
    }

    void FixedUpdate()
    {
        if (move)
        {
            //Sets the velocity on the x axis
            GetComponent<Rigidbody2D>().velocity 
                = new Vector2(speed.x * inputX, GetComponent<Rigidbody2D>().velocity.y);

            // If the player wants to jump...
            if (jump)
            {
                //Gives a small delay before the character can jump
                if (jumpTime < jumpDelay)
                    jumpTime += (Time.fixedDeltaTime);
                else
                {
                    //Sets the velocity on the y axis	
                    GetComponent<Rigidbody2D>().velocity 
                        = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed.y);

                    // Make sure the player can't jump again until the jump conditions from Update are satisfied.
                    jump = false;

                    jumpTime = 0;
                }
            }
        }
        else //in case the character is locked for some reason
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}