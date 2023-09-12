using UnityEngine;

public class VinylController : MonoBehaviour
{
    [SerializeField] private float rotationSpeedY = 30f;
    [SerializeField] private float wobbleSpeedX = 5f;
    [SerializeField] private float wobbleAmountX = 0.01f;

    private float time = 0f;

    private void Update()
    {
        // Increment the time value.
        time += Time.deltaTime;

        // Calculate the rotation angle around Y-axis with the base rotation speed.
        float rotationAngleY = rotationSpeedY * Time.deltaTime;

        // Calculate the wobble angle around X-axis based on a sinusoidal motion.
        float wobbleAngleX = wobbleAmountX * Mathf.Sin(wobbleSpeedX * time);

        // Combine the rotation and wobble angles.
        float totalRotationY = rotationAngleY;

        // Apply the rotation and wobble.
        transform.Rotate(Vector3.up, totalRotationY);
        transform.Rotate(Vector3.right, wobbleAngleX);
    }
}
