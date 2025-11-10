using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [Tooltip("Name of the next scene to load after this level is complete.")]
    public string nextSceneName;

    private void OnEnable()
    {
        LevelEvents.OnLevelComplete += HandleLevelComplete;
    }

    private void OnDisable()
    {
        LevelEvents.OnLevelComplete -= HandleLevelComplete;
    }

    private void HandleLevelComplete()
    {
        Debug.Log("Level complete! Loading next scene...");
        if (!string.IsNullOrEmpty(nextSceneName))
            SceneManager.LoadScene(nextSceneName);
        else
            SceneManager.LoadScene("WinScene");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}
