using System;

public static class LevelEvents
{
    public static Action OnLevelComplete;

    public static void RaiseLevelComplete()
    {
        OnLevelComplete?.Invoke();
    }
}
