using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateMesh : MonoBehaviour
{
    // Referencia al XR Simple Interactable
    public XRBaseInteractable interactable;

    // Referencia al objeto que contiene el Mesh Renderer a activar
    public GameObject handAserrin;

    void OnEnable()
    {
        // Asegúrate de que el interactable y handAserrin no son nulos
        if (interactable != null && handAserrin != null)
        {
            interactable.selectEntered.AddListener(ActivateMeshRenderer);
        }
    }

    void OnDisable()
    {
        if (interactable != null)
        {
            interactable.selectEntered.RemoveListener(ActivateMeshRenderer);
        }
    }

    private void ActivateMeshRenderer(SelectEnterEventArgs args)
    {
        // Activar el Mesh Renderer
        MeshRenderer renderer = handAserrin.GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = true;
        }
    }
}
