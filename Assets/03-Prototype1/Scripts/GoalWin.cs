using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalWin : MonoBehaviour
{
    private bool playerReached = false;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        // Make the material transparent at the start
        rend.material.color = new Color(1f, 1f, 1f, 0.5f);
    }

    void Update()
    {
        // If the player has reached the GoalWin, make the material fully opaque
        if (playerReached)
        {
            rend.material.color = Color.white;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Set the flag to indicate that the player has reached GoalWin
            playerReached = true;
        }
    }
}
