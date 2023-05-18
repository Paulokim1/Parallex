using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the camera moves

    void Update()
    {
        // Move the camera to the right
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
