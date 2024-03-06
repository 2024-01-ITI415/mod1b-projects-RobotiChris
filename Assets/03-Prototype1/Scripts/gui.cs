using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Player player; // Reference to the Player script

    private Text livesText;

    void Start()
    {
        livesText = GetComponent<Text>();
    }

    void Update()
    {
        // Update the text to show the remaining lives
        livesText.text = "Lives: " + player.GetLives();
    }
}
