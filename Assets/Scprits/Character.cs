﻿using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    public bool interacting = false;
    private CharacterMovement charMovement;
    private int standartLayer;

    private bool grounded = false;          // Whether or not the player is grounded.
    private Transform groundCheck;          // A position marking where to check if the player is grounded.
    private bool flip = false;
    private float sensibility;

    void Start()
    {
        charMovement = gameObject.GetComponent<CharacterMovement>();
        sensibility = GetComponent<CharacterMovement>().sensibility;
    }

    public bool isGrounded
    {
        get { return grounded; }
        set { grounded = value; }
    }

    public bool Flip
    {
        get { return flip; }
        set { flip = value; }
    }

    void Awake()
    {
        groundCheck = transform.Find("groundCheck");
    }

    public void ChangeLayer(int new_order)
    {
        Vector3 new_pos;
        new_pos = transform.position;
        new_pos.z = new_order;
        transform.position = new_pos;
    }

    public void ResetLayer()
    {
        Vector3 new_pos;
        new_pos = transform.position;
        new_pos.z = 0;
        transform.position = new_pos;
    }

    void Update()
    {
        // Rotates the character when it moves to the opposite side
        if ((Input.GetAxis("Horizontal") < -sensibility  && flip == false) 
            || (Input.GetAxis("Horizontal") > sensibility && flip == true))
        {
            gameObject.transform.Rotate(new Vector2(0, 180));
            flip = !flip;
        }

        charMovement.move = !interacting;
    }
}