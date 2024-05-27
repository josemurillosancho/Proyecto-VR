using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 
 
public class BucketSocketInteractor : XRSocketInteractor  
{ 
    public override bool CanSelect(IXRSelectInteractable interactable)  
    { 
        XRBaseInteractable baseInteractable = interactable as XRBaseInteractable; 
 
        // Check if the interactable has the "bucket" tag 
        if (baseInteractable != null && baseInteractable.gameObject.CompareTag("bucket"))  
        { 
            return base.CanSelect(interactable); 
        } 
        return false; 
    } 
}