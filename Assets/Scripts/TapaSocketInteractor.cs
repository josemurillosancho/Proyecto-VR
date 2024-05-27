using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 
 
public class TapaSocketInteractor : XRSocketInteractor  
{ 
    public override bool CanSelect(IXRSelectInteractable interactable)  
    { 
        XRBaseInteractable baseInteractable = interactable as XRBaseInteractable; 
 
        // Check if the interactable has the "tapa" tag 
        if (baseInteractable != null && baseInteractable.gameObject.CompareTag("tapa"))  
        { 
            return base.CanSelect(interactable); 
        } 
        return false; 
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        SetColliderTrigger(args.interactableObject, true);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        SetColliderTrigger(args.interactableObject, false);
    }

    void SetColliderTrigger(IXRInteractable interactable, bool isTrigger)
    {
        // Convert the interactable to XRBaseInteractable to access the GameObject
        XRBaseInteractable baseInteractable = interactable as XRBaseInteractable;
        if (baseInteractable != null)
        {
            // Get the Mesh Collider component and set its 'isTrigger' property
            MeshCollider meshCollider = baseInteractable.GetComponent<MeshCollider>();
            if (meshCollider != null)
            {
                meshCollider.isTrigger = isTrigger;
            }
        }
    } 
}