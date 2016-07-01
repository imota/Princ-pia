using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    private bool attack;
    public float time;
    private Timer timer;

    void Start()
    {
        //timer.Set(time);
    }

	void LateUpdate()
    {
        if (Input.GetKeyDown("space") || Input.GetKeyDown("joystick button 2"))
        {
            attack = true;
            //timer.Set(time);
        }
        if (true)//timer.IsOver() == false)
        {
            //timer.Run();
            GetComponent<Animator>().SetBool("Idle", false);
            GetComponent<Animator>().SetBool("Walking", false);
            GetComponent<Animator>().SetBool("Fall", false);
            GetComponent<Animator>().SetBool("Jump", false);
            GetComponent<Animator>().SetBool("Attack", true);
        }
    }
}
