using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [Header("Timer Settings")]
    public float levelTime = 120f; // 2 minutes per level
    public Text timerText;

    private float currentTime;
    private bool levelEnded = false;

    void Start()
    {
        currentTime = levelTime;
    }

    void Update()
    {
        if (levelEnded) return;

        currentTime -= Time.deltaTime;

        if (timerText != null)
            timerText.text = "Time: " + Mathf.CeilToInt(currentTime).ToString();

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            levelEnded = true;
            HandleLose();
        }
    }

    private void HandleLose()
    {
        SceneManager.LoadScene("LoseScene");
    }

    public void StopTimerAndWin()
    {
        if (levelEnded) return;
        levelEnded = true;

        LevelEvents.RaiseLevelComplete();
    }
}
