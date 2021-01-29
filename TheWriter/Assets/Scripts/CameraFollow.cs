﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /// Target of the camera
    public Transform target;

    /// Minimum position of camera
    public float minPosition = -5.3f;

    /// Maximum position of camera
    public float maxPosition = 5.3f;

    /// Movement speed of camera
    public float moveSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        var newPosition = Vector3.Lerp(transform.position, target.position, moveSpeed * Time.deltaTime);

        newPosition.x = Mathf.Clamp(newPosition.x, minPosition, maxPosition);
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z;

        transform.position = newPosition;
    }

}
