using UnityEngine;

public class DeactivateMeshOnCollision : MonoBehaviour
{
    private int desactivationCount = 0;  // Contador de desactivaciones

    // Referencia directa al objeto con el que debe colisionar para desactivar el Mesh Renderer
    public GameObject targetObject;

    // Referencia al objeto hijo que contiene el Mesh Renderer a desactivar
    public GameObject handAserrin;

    // Objetos que contienen los diferentes MeshRenderers
    public GameObject capaInicial;
    public GameObject barrera1;
    public GameObject barrera2;
    public GameObject barrera3;

    // Cacas específicas que deben estar activas para permitir la activación de las barreras
    public GameObject shit1;
    public GameObject shit2;
    public GameObject shit3;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == targetObject)
        {
            MeshRenderer handAserrinRenderer = handAserrin.GetComponent<MeshRenderer>();

            // Verificar si el Mesh de handAserrin está activado
            if (handAserrinRenderer != null && handAserrinRenderer.enabled)
            {
                desactivationCount++;  // Incrementar el contador cada vez que colisiona con aserrín

                // Desactivar todos los MeshRenderers primero
                DisableAllMeshes();

                // Lógica para activar el mesh correspondiente
                if (desactivationCount == 1)
                {
                    ActivateMeshRenderer(capaInicial);
                }
                else if (desactivationCount == 2 && shit1.GetComponent<MeshRenderer>().enabled)
                {
                    ActivateMeshRenderer(barrera1);
                }
                else if (desactivationCount == 3 && shit2.GetComponent<MeshRenderer>().enabled)
                {
                    ActivateMeshRenderer(barrera2);
                }
                else if (desactivationCount == 4 && shit3.GetComponent<MeshRenderer>().enabled)
                {
                    ActivateMeshRenderer(barrera3);
                }
                else if (desactivationCount >= 5)
                {
                    desactivationCount = 0;  // Opcional: Reinicia el contador si quieres que cicle entre los meshes
                }

                // Desactivar el Mesh Renderer de handAserrin para simbolizar que el aserrín ha sido depositado
                handAserrinRenderer.enabled = false;
            }
        }
    }

    private void DisableAllMeshes()
    {
        capaInicial.GetComponent<MeshRenderer>().enabled = false;
        barrera1.GetComponent<MeshRenderer>().enabled = false;
        barrera2.GetComponent<MeshRenderer>().enabled = false;
        barrera3.GetComponent<MeshRenderer>().enabled = false;
        shit1.GetComponent<MeshRenderer>().enabled = false;
        shit2.GetComponent<MeshRenderer>().enabled = false;
        shit3.GetComponent<MeshRenderer>().enabled = false;
    }

    private void ActivateMeshRenderer(GameObject meshObject)
    {
        MeshRenderer renderer = meshObject.GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = true;
        }
    }
}
