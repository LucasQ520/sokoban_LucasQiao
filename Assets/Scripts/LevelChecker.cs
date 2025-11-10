using UnityEngine;

public class LevelChecker : MonoBehaviour
{
    private static Goal[] goals;
    private static LevelTimer timer;

    private void Awake()
    {
        goals = FindObjectsOfType<Goal>();
        timer = FindObjectOfType<LevelTimer>();
    }

    public static void CheckAllGoals()
    {
        if (goals == null || goals.Length == 0)
            return;

        foreach (Goal goal in goals)
        {
            if (!goal.isOccupied)
                return;
        }

        Debug.Log("All goals covered! You win!");
        if (timer != null)
            timer.StopTimerAndWin();
    }
}
