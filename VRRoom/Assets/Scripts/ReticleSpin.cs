using UnityEngine;

public class ReticleSpin : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 10.0f;

    private void Update()
    {
        // Rotate reticle around its up vector (Y-axis) over time.
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
