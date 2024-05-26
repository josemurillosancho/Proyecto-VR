using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 
 
public class CustomXRSocketInteractor : XRSocketInteractor  
{ 
    public override bool CanSelect(IXRSelectInteractable interactable)  
    { 
        XRBaseInteractable baseInteractable = interactable as XRBaseInteractable; 
 
        // Check if the interactable has the "seed" tag 
        if (baseInteractable != null && baseInteractable.gameObject.CompareTag("tapa"))  
        { 
            return base.CanSelect(interactable); 
        } 
        return false; 
    } 
}