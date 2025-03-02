using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string questionSceneName = "QuestionScene";  // Name of the Question Scene
    [SerializeField] private string nextSceneName;  // Next Level Name

    void OnMouseDown()
    {
        Debug.Log("Level Completed! Loading Question Scene...");
        PlayerPrefs.SetString("NextLevel", nextSceneName);  // Save next level name
        SceneManager.LoadScene(questionSceneName);  // Load question scene
    }
}
