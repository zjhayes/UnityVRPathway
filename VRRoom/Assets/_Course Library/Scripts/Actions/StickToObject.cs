using UnityEngine;

/// <summary>
/// On collision align the object with the normal of the surface that was hit
/// </summary>
public class StickToObject : MonoBehaviour
{
    public void AlignWithSurface(Collision collision)
    {
        ContactPoint contactPoint = collision.GetContact(0);
        transform.up = -contactPoint.normal;
    }

    public void AlignWithSurface(Collider collider)
    {
        // Get the contact point information
        Vector3 contactPoint = collider.ClosestPoint(transform.position);
        Vector3 surfaceNormal = (transform.position - contactPoint).normalized;

        // Align the object with the surface normal
        transform.up = surfaceNormal;
    }

}
