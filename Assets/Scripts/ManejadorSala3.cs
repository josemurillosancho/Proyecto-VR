using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorSala3 : MonoBehaviour
{
    public string expectedTag; // Tag esperado para el objeto que debe entrar en esta caja
    public Vector3 respawnPosition;  // Lugar de Respawn si entró el objeto equivocado
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public BoxCollider boxCollider;
    public int boxID; // ID para identificar la caja (1 o 2)

    public Animator characterAnimator; // Referencia al Animator del personaje
    public RuntimeAnimatorController talk;
    public RuntimeAnimatorController relax;

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que ha entrado en la caja tiene el Tag correcto
        if (other.CompareTag(expectedTag))
        {
            // Se destruye el Objeto
            Destroy(other.gameObject);

            // Actualizar el estado en DepositManager
            if (boxID == 1)
            {   
                DepositManager.object1Deposited = true;
                if (DepositManager.AreBothObjectsDeposited())
                {
                    audioSource.clip = audioClips[1]; // Ambos objetos correctos
                    audioSource.Play();
                    // Se habilita la pared 
                    boxCollider.enabled = false;
                }
                else {
                    audioSource.clip = audioClips[0]; // Objeto correctamente
                    audioSource.Play();
                }
                
                
            }
            else if (boxID == 2)
            {
                DepositManager.object2Deposited = true;

                if (DepositManager.AreBothObjectsDeposited())
                {
                    audioSource.clip = audioClips[1]; // Ambos objetos correctos
                    audioSource.Play();
                    // Se habilita la pared 
                    boxCollider.enabled = false;
                }
                else {
                    audioSource.clip = audioClips[0]; // Objeto correctamente
                    audioSource.Play();
                }
            }

            
        }
        else
        {
            // El objeto no es del tipo correcto
            audioSource.clip = audioClips[2];
            audioSource.Play();
            // Respawn del objeto
            other.transform.position = respawnPosition;
            
        }
        
    }
}
