/**
 * FollowObjectScript
 * A script that determines when an object will always follow another by a determined offset.
 */

using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
    public GameObject followed;
    public Vector3 offset;

    private Vector3 followedPos;

    void Start()
    {
        UpdatePosition();
    }

    void LateUpdate()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {
        if (followed != null)
        {
            followedPos = followed.transform.position;
            transform.position = followedPos + offset;
        }
    }
}