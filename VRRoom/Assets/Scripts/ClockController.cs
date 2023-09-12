using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ClockController : MonoBehaviour
{
    [SerializeField] private Transform hourHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private Transform secondHand;

    private AudioSource tickSound;
    private float previousSecond = -1f;

    private void Awake()
    {
        tickSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        UpdateClockHands();
        PlayTickSound();
    }

    private void UpdateClockHands()
    {
        int currentHour = System.DateTime.Now.Hour;
        int currentMinute = System.DateTime.Now.Minute;
        int currentSecond = System.DateTime.Now.Second;

        float hourRotation = (currentHour % 12 + currentMinute / 60f) * 360f / 12f;
        float minuteRotation = (currentMinute + currentSecond / 60f) * 360f / 60f;
        float secondRotation = currentSecond * 360f / 60f;

        hourHand.localRotation = Quaternion.Euler(hourRotation, 0f, 0f);
        minuteHand.localRotation = Quaternion.Euler(minuteRotation, 0f, 0f);
        secondHand.localRotation = Quaternion.Euler(secondRotation, 0f, 0f);
    }

    private void PlayTickSound()
    {
        int currentSecond = System.DateTime.Now.Second;

        if (currentSecond != previousSecond)
        {
            tickSound.Play();

            previousSecond = currentSecond;
        }
    }
}