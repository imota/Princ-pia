using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Character charScript = otherCollider.gameObject.GetComponent<Character>();
        if (charScript != null)
        {
            otherCollider.gameObject.GetComponent<Life>().Kill();
        }
    }
}