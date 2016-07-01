using UnityEngine;
using System.Collections;

public class LifeCounter : MonoBehaviour {

    public GameObject character;
    public GameObject life1, life2, life3;

    void Update()
    {
        if (!character)
            return;
        float life = character.GetComponent<Life>().life;
        if (life < 3)
            life3.GetComponent<Renderer>().enabled = false;
        else
            life3.GetComponent<Renderer>().enabled = true;
        if (life < 2)
            life2.GetComponent<Renderer>().enabled = false;
        else
            life2.GetComponent<Renderer>().enabled = true;
        if (life < 1)
            life1.GetComponent<Renderer>().enabled = false;
        else
            life1.GetComponent<Renderer>().enabled = true;
    }
}
