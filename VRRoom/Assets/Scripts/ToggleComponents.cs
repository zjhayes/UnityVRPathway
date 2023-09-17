using UnityEngine;

public class ToggleComponents : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour defaultComponent;
    [SerializeField]
    private MonoBehaviour secondaryComponent;
    [SerializeField]
    private bool inverse;

    public void Toggle(bool enable)
    {
        // Invert which component is enabled when "true".
        enable = inverse ? !enable : enable;

        defaultComponent.enabled = enable;
        secondaryComponent.enabled = !enable;
    }
}
