using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isOccupied = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Block>() != null)
        {
            isOccupied = true;
            LevelChecker.CheckAllGoals();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Block>() != null)
        {
            isOccupied = false;
            LevelChecker.CheckAllGoals();
        }
    }
}
