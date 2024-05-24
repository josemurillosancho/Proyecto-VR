using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandInteract : MonoBehaviour
{
    public Animator characterAnimator; // Referencia al Animator del personaje
    public RuntimeAnimatorController talk;
    public RuntimeAnimatorController relax;
    public AudioSource characterAudio; // Referencia al AudioSource del personaje

    private void OnTriggerEnter(Collider other)
    {
        characterAnimator.runtimeAnimatorController = talk;
        characterAudio.Play(); 
    }

    private void OnTriggerExit(Collider other)
    {
        characterAnimator.runtimeAnimatorController = relax;
        characterAudio.Stop(); 
    }
}
