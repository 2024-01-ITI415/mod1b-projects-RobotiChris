using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab of the bullet to shoot
    public Transform firePoint; // Point where the bullet will be spawned
    public float bulletSpeed = 10f; // Speed of the bullet
    public float shootingInterval = 0.5f; // Interval between each shot

    void Start()
    {
        // Start shooting bullets repeatedly after a delay of 0 seconds,
        // with the specified interval
        InvokeRepeating("Shoot", 0f, shootingInterval);
    }

    void Shoot()
    {
        // Create a new bullet instance at the fire point position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the bullet
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

        // Check if the bullet's Rigidbody is not null
        if (bulletRb != null)
        {
            // Shoot the bullet forward
            bulletRb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}