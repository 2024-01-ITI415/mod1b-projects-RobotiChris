using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int totalCoins;
    private int collectedCoins = 0;
    private int lives = 3;

    public GameObject goalWin; // Reference to the GoalWin GameObject

    public int GetLives()
    {
        return lives;
    }

    void Start()
    {
        // Count the total number of coins in the scene
        totalCoins = GameObject.FindGameObjectsWithTag("Coins").Length;
        // Hide the GoalWin GameObject at the start
        goalWin.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coins"))
        {
            // Disable the collected coin
            other.gameObject.SetActive(false);
            // Increment the collected coins count
            collectedCoins++;

            // Check if all coins are collected
            if (collectedCoins >= totalCoins)
            {
           
            }
        }


    

        if (other.CompareTag("Bullet"))
        {
            // Reduce player's lives
            lives--;
            Debug.Log("Player hit by enemy bullet. Lives remaining: " + lives);

            // Check if player has run out of lives
            if (lives <= 0)
            {
                // Restart the level
                RestartLevel();
            }
        }

        void RestartLevel()
        {
            // Get the current scene index
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Reload the current scene
            SceneManager.LoadScene(currentSceneIndex);
        }


    }
}