using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    private bool attack;
    public float time;
    private Timer timer;

    void Start()
    {
        timer = GetComponent<Timer>();
    }

	void Update()
    {
        if (!attack && (Input.GetKeyDown("space") || Input.GetKeyDown("joystick button 2")))
        {
            attack = true;
            GetComponent<Animator>().SetBool("Attack", true);
            timer.Set(time);
        }
        if (timer.IsOver() == false && attack)
        {
            timer.Run();
            GetComponent<Animator>().SetBool("Idle", false);
            GetComponent<Animator>().SetBool("Walking", false);
            GetComponent<Animator>().SetBool("Fall", false);
            GetComponent<Animator>().SetBool("Jump", false);
        }
        else
        {
            attack = false;
            timer.Reset();
            GetComponent<Animator>().SetBool("Attack", false);
        }
    }
}
