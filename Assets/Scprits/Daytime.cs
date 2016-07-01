using UnityEngine;
using System.Collections;

public class Daytime : MonoBehaviour {

    public GameObject character;
    public float night_time;

	void Update () {
        Animator animator = GetComponent< Animator>() ;
        if (character.transform.position.x > night_time)
        {
            if (animator.GetBool("Night") == false)
                animator.SetBool("Night", true);
        }
	}
}
