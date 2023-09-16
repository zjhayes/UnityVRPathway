using UnityEngine;

/// <summary>
/// Toggles particle system
/// </summary>
[RequireComponent(typeof(ParticleSystem))]
public class ToggleParticle : MonoBehaviour
{
    [SerializeField]
    private bool playOnAwake = true;

    private ParticleSystem currentParticleSystem = null;
    private MonoBehaviour currentOwner = null;

    private void Awake()
    {
        currentParticleSystem = GetComponent<ParticleSystem>();

        if(!playOnAwake)
        {
            Stop();
        }
    }

    public void Play()
    {
        currentParticleSystem.Play();
    }

    public void Toggle()
    {
        if(currentParticleSystem.isPlaying)
        {
            Stop();
        }
        else
        {
            Play();
        }
    }

    public void Stop()
    {
        currentParticleSystem.Stop();
    }

    public void PlayWithExclusivity(MonoBehaviour owner)
    {
        if(currentOwner == null)
        {
            currentOwner = this;
            Play();
        }
    }

    public void StopWithExclusivity(MonoBehaviour owner)
    {
        if(currentOwner == this)
        {
            currentOwner = null;
            Stop();
        }
    }

    private void OnValidate()
    {
        if(currentParticleSystem)
        {
            ParticleSystem.MainModule main = currentParticleSystem.main;
            main.playOnAwake = false;
        }
    }
}
