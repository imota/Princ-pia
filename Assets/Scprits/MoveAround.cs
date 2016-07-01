using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

    public float speed = 1f;

    private Vector2 origin;
    private Vector2 checkpoint;
    private bool moving_to_checkpoint;

    private bool has_rigidbody;
    private Rigidbody2D rb;

    void Start() {
        origin = transform.position;
        checkpoint = transform.FindChild("Checkpoint").position;
        moving_to_checkpoint = true;
        rb = GetComponent<Rigidbody2D>();
        has_rigidbody = rb;
    }

    void Update() {
        if (Vector2.Distance((Vector2)transform.position, CurrentDestination()) <= Mathf.Epsilon) {
            moving_to_checkpoint = !moving_to_checkpoint;
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.flipX = !sr.flipX;
        }
        else {
            Vector2 dst_point = Vector2.MoveTowards(transform.position,
                CurrentDestination(), speed * Time.deltaTime);
            if (has_rigidbody)
                rb.MovePosition(dst_point);
            else
                transform.position = dst_point;
        }
    }

    Vector2 CurrentDestination() {
        return moving_to_checkpoint ? checkpoint : origin;
    }
}
