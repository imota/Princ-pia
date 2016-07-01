using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

    public GameObject character;
    public Vector3 restart_point;

    void Update()
    {
        if (character.GetComponent<Life>().isDead())
        {
            character.GetComponent<Life>().Heal();
            character.transform.position = restart_point;
        }
    }
}
