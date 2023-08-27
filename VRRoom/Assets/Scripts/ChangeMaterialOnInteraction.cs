using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ChangeMaterialOnInteraction : MonoBehaviour
{
    [SerializeField]
    private Material idleMaterial;
    [SerializeField]
    private Material interactionMaterial;

    private new Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        OnIdle();
    }

    public void OnIdle()
    {
        renderer.material = idleMaterial;
    }

    public void OnInteract()
    {
        renderer.material = interactionMaterial;
    }
}
