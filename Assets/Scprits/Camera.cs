using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    public Transform character;
    public float leftLimit = -5f, rightLimit = 5.15f, 
                 upperLimit = 0, lowerLimit = -0.025f;
    private Vector3 pos;
    private float size;

    void Start()
    {
        size = GetComponent<Camera>().size;
        pos = character.transform.position + new Vector3(size/2,size/2,-10);
        transform.position = character.transform.position;
    }

    void Update()
    {
        if (character) {
            pos = character.transform.position + new Vector3(size / 2, size / 2, -9);
            if (pos.x < leftLimit) pos.x = leftLimit;
            if (pos.x > rightLimit) pos.x = rightLimit;
            if (pos.y < lowerLimit) pos.y = lowerLimit;
            if (pos.y > upperLimit) pos.y = upperLimit;
            transform.position = pos;
        }
    }
}