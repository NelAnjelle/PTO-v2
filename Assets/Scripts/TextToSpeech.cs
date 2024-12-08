using UnityEngine;
using UnityEngine.UI;

public class TextToSpeech : MonoBehaviour
{

    public GameObject MonitorToPlaySound;
    private AudioSource NumerianaTTS; // Reference to the AudioSource
    private bool hasPlayed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         // Get the AudioSource component attached to this GameObject
        NumerianaTTS = GetComponent<AudioSource>();

        if (NumerianaTTS == null)
        {
            Debug.LogError("No AudioSource found on this GameObject!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MonitorToPlaySound != null && MonitorToPlaySound.activeSelf && !hasPlayed)
        {
            if (NumerianaTTS != null)
            {
                NumerianaTTS.Play(); // Play the sound
                hasPlayed = true;  // Prevent it from playing again
            }
        }
    }
}
