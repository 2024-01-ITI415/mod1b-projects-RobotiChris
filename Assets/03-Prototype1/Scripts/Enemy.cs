using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        // Ensure player reference is not null and the player is active in the scene
        if (player != null && player.gameObject.activeSelf)
        {
            // Calculate direction from enemy to player
            Vector3 direction = player.position - transform.position;
            direction.y = 0; // Optional: Ensure no tilting in the y-axis

            // Rotate enemy to face player
            if (direction != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f); // Adjust rotation speed as needed
            }
        }
    }
}
