using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class AserrinCollisionManager : MonoBehaviour
{
    // Referencia al objeto con el que debe colisionar para desactivar el Mesh Renderer y activar barreras
    public GameObject targetObject;

    // Referencia al objeto hijo que contiene el Mesh Renderer a desactivar
    public GameObject handAserrin;

    // Objetos que contienen los diferentes MeshRenderers de las barreras
    public GameObject[] meshBarreras;

    // Objetos que contienen los diferentes MeshRenderers, solo para referencia, no modificamos aquí
    public GameObject[] meshObjects;
    public XRSocketInteractor socket; // Socket para la tapa del balde

    private void Awake()
    {
        // Suscribirse al evento onSelectEntered del socket
        socket.selectEntered.AddListener(HandleSocketEntered);
    }
    private int currentMeshIndex = -1;  // Índice del mesh de barrera activo actualmente

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == targetObject)
        {
            if (gameObject.GetComponent<MeshRenderer>().enabled) {

            }
            // Desactivar el Mesh Renderer de handAserrin para simbolizar que el aserrín ha sido depositado
            MeshRenderer handAserrinRenderer = handAserrin.GetComponent<MeshRenderer>();
            if (handAserrinRenderer != null && handAserrinRenderer.enabled)
            {                
                // Llamar a la función para manejar la activación de las barreras
                HandleBarrierActivation();
                handAserrinRenderer.enabled = false;
            }
        }
    }

    void HandleBarrierActivation()
    {
        int activeMeshIndex = FindActiveMeshIndex();
        int nextMeshIndex = (activeMeshIndex + 1) % meshBarreras.Length;

        if (activeMeshIndex == -1) // No hay ninguno activo, activa el primer mesh
        {
            ActivateMeshRenderer(meshBarreras[0]);
        }
        else if (meshObjects[activeMeshIndex].GetComponent<MeshRenderer>().enabled)
        {
            DeactivateAllMeshes();
            ActivateMeshRenderer(meshBarreras[nextMeshIndex]);
        }
    }

    void HandleSocketEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("tapa"))
        {
            foreach (GameObject mesh in meshObjects)
            {
                mesh.GetComponent<MeshRenderer>().enabled = false;
            }
            DeactivateAllMeshes(); // "Vaciar" la cubeta
            Debug.Log("La tapa ha sido colocada y la cubeta se ha 'vacíado'.");
        }
    }

    private int FindActiveMeshIndex()
    {
        for (int i = 0; i < meshBarreras.Length; i++)
        {
            if (meshBarreras[i].GetComponent<MeshRenderer>().enabled)
            {
                return i;
            }
        }
        return -1; // No se encontró ningún mesh activo
    }

    private void ActivateMeshRenderer(GameObject meshObject)
    {
        MeshRenderer renderer = meshObject.GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = true;
        }
    }

    private void DeactivateAllMeshes()
    {
        foreach (GameObject mesh in meshBarreras)
        {
            mesh.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
