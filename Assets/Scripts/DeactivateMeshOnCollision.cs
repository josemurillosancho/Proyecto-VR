using UnityEngine;

public class DeactivateMeshOnCollision : MonoBehaviour
{
    // Referencia directa al objeto con el que debe colisionar para desactivar el Mesh Renderer
    public GameObject targetObject;

    // Referencia al objeto hijo que contiene el Mesh Renderer a desactivar
    public GameObject handAserrin;

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si la colisión es con el objeto objetivo
        if (collision.gameObject == targetObject)
        {
            // Obtener el componente MeshRenderer de handAserrin
            MeshRenderer handAserrinRenderer = handAserrin.GetComponent<MeshRenderer>();

            // Verificar si el Mesh de handAserrin está activado y desactivarlo
            if (handAserrinRenderer != null && handAserrinRenderer.enabled)
            {
                handAserrinRenderer.enabled = false;
                Debug.Log("handAserrin MeshRenderer has been deactivated due to collision with targetObject.");
            }
        }
    }
}
