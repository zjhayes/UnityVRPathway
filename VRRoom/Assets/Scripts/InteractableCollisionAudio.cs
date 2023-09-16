using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(PlayQuickSound))]
public class InteractableCollisionAudio : MonoBehaviour
{
    [SerializeField]
    private float volumeMultiplier = 1.0f;
    [SerializeField]
    private float minimumVelocity = 0.1f;

    private AudioSource audioSource;
    private PlayQuickSound sound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        sound = GetComponent<PlayQuickSound>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        // Check if the relative velocity magnitude is greater than a threshold.
        if (collision.relativeVelocity.magnitude > minimumVelocity && !audioSource.isPlaying)
        {
            // Scale the volume based on collision magnitude.
            float scaledVolume = collision.relativeVelocity.magnitude * volumeMultiplier;
            // Play the audio clip
            sound.volume = scaledVolume;
            sound.Play();
        }
    }
}
