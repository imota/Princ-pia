using UnityEngine;
using System.Collections;

public class BG_Scroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = GetComponent<Transform>().position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        GetComponent<Transform>().position = startPosition + Vector3.forward * newPosition;
    }
}