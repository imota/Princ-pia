using UnityEngine;
using System.Collections;

public class Sleeping : MonoBehaviour {

    public GameObject character;

    void Start()
    {
        character.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0.2 || Input.GetAxis("Horizontal") < -0.2 ||
            Input.GetKeyDown("w") || Input.GetKeyDown("joystick button 0"))
            Move();
    }

    private void Move()
    {
        character.GetComponent<Renderer>().enabled = true;
        GetComponent<Renderer>().enabled = false;
    }
}
