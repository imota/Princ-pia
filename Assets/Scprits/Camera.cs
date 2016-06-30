using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    public Transform character;
    [HideInInspector]
    public float leftLimit, rightLimit, upperLimit, lowerLimit;
    [HideInInspector]
    private Vector3 pos;
    private float size;

    void Start()
    {
        DefaultLimits();
        size = GetComponent<Camera>().size;
        pos = character.transform.position + new Vector3(size/2,size/2,-10);
        transform.position = character.transform.position;
    }

    void Update()
    {
        if (character) {
            pos = character.transform.position + new Vector3(size / 2, size / 2, -10);
            if (pos.x < leftLimit) pos.x = leftLimit;
            if (pos.x > rightLimit) pos.x = rightLimit;
            if (pos.y < lowerLimit) pos.y = lowerLimit;
            //if (pos.y > upperLimit) pos.y = upperLimit;
            transform.position = pos;
        }
    }

    void DefaultLimits()
    {
        leftLimit = -5f;
        rightLimit = 3.4f;
        upperLimit = (float)1.27;
        lowerLimit = -0.04f;
    }
}