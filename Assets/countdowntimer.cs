using UnityEngine;
using TMPro;  
using UnityEngine.SceneManagement;  // For loading scenes

public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 60f;  // Countdown duration
    public TextMeshProUGUI timerText;  // Assign UI Text in Inspector
    public string menuSceneName = "MainMenu";  // Set the menu scene name
    public AudioSource warningSound;  // Assign an AudioSource in Inspector
    private bool audioPlayed = false;  // Prevent multiple plays

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.Ceil(timeLeft).ToString(); // Round to whole number

            // Change text color to red when 10 seconds remain
            if (timeLeft <= 10)
            {
                timerText.color = Color.red;
                
                // Play warning sound only once
                if (!audioPlayed)
                {
                    warningSound.Play();  // Play audio
                    audioPlayed = true;  // Ensure it only plays once
                }
            }
        }
        else
        {
            timerText.text = "Time's Up!";
            Invoke("LoadMenuScene", 2f);  // Delay before opening menu
        }
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene(menuSceneName);  // Load Menu Scene
    }
}
