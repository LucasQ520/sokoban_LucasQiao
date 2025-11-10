using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BlockSFX : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void BlockMoved(Vector2Int change)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
