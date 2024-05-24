using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorSala3 : MonoBehaviour
{
    public string expectedTag; // Tag esperado para el objeto que debe entrar en esta caja
    public Vector3 respawnPosition;  // Lugar de Respawn
    public Vector3 respawnPosition2;  // Lugar de Respawn
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public BoxCollider boxCollider;

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que ha entrado en la caja tiene el Tag correcto
        if (other.CompareTag(expectedTag))
        {
            // El objeto es del tipo correcto, realiza la acción correspondiente
            Debug.Log("Objeto correcto en la caja " + gameObject.name);
            audioSource.clip = audioClips[0];
            audioSource.Play();
            
            other.transform.position = respawnPosition;
            boxCollider.enabled = false;
        }
        else
        {
            // El objeto no es del tipo correcto, realiza una acción de error o ignora la colisión
            Debug.Log("Objeto incorrecto en la caja " + gameObject.name);
            audioSource.clip = audioClips[1];
            audioSource.Play();
            
            other.transform.position = respawnPosition2;
            
        }
        
    }
}
