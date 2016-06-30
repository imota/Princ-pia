using UnityEngine;

public class BG_Scroller : MonoBehaviour
{
    public float speed = 2;
    private Vector2 direction;
    public bool isLinkedToCamera = false;

    public GameObject character;

    void Update()
    {
        Vector2 real_speed = speed * 
            new Vector2(character.GetComponent<Rigidbody2D>().velocity.x,0);
        Vector3 movement = 
            new Vector3(real_speed.x * -1, real_speed.y * -1, 0);

        movement *= Time.deltaTime;
        transform.Translate(movement);

        if (isLinkedToCamera)
        {
            //Camera.main.transform.Translate(movement);
        }
    }
}