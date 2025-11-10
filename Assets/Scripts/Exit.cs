using UnityEngine;

public class Exit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached Exit! Level complete!");
            LevelEvents.RaiseLevelComplete();
        }
    }
}
