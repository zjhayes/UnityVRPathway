using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

[RequireComponent(typeof(XRBaseInteractor))]
public class ToggleInteractionLayer : MonoBehaviour
{
    [SerializeField]
    private InteractionLayerMask targetLayers = 0;

    private XRBaseInteractor interactor = null;

    private void Awake()
    {
        interactor = GetComponent<XRBaseInteractor>();
    }

    public void Toggle(bool enable)
    {
        if(enable)
        {
            interactor.interactionLayers += targetLayers;
        }
        else
        {
            interactor.interactionLayers -= targetLayers;
        }
    }
}
