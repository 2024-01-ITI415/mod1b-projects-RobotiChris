using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f; // Speed of the bullet
    void Update()
    {
        // Move the bullet forward at the increased speed
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

        // Check if the bullet went off-screen
        if (!IsOnScreen())
        {
            Destroy(gameObject);
        }
    }
    private bool IsOnScreen()
    {
        // Check if the bullet is within the screen boundaries
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
        return screenPoint.x >= 0 && screenPoint.x <= 1 && screenPoint.y >= 0 && screenPoint.y <= 1;
    }
}
