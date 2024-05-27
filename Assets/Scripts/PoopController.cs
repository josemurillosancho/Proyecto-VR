using System.Collections;
using UnityEngine;

public class PoopController : MonoBehaviour
{
    public HingeJoint hingeJoint;  // Referencia al Hinge Joint
    public GameObject meshObject1;  // Primer objeto con MeshRenderer
    public GameObject meshObject2;  // Segundo objeto con MeshRenderer
    public GameObject meshObject3;  // Tercer objeto con MeshRenderer

    public GameObject meshBarrera1;  // Tercer objeto con MeshRenderer

    public GameObject meshBarrera2;  // Tercer objeto con MeshRenderer

    public GameObject meshBarrera3;  // Tercer objeto con MeshRenderer


    private int activationCount = 0;  // Contador para manejar las activaciones
    private bool hasOpened = false;  // Flag para registrar si ha pasado los -50 grados

    void Start()
    {
        StartCoroutine(HingeMonitor());
    }

    IEnumerator HingeMonitor()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);  // Revisar el ángulo cada 0.5 segundos
            if (hingeJoint != null)
            {
                if (hingeJoint.angle != 0)
                    hasOpened = true;
                
                if (hasOpened && Mathf.Approximately(hingeJoint.angle, 0))
                {
                    HandleMeshActivation();
                    hasOpened = false;  // Reset para la próxima vez
                }
            }
        }
    }

    void HandleMeshActivation()
    {
        // Incrementar el contador cada vez que el hinge joint llega a 0
        activationCount++;

        // Desactivar todos los meshes
        meshObject1.GetComponent<MeshRenderer>().enabled = false;
        meshObject2.GetComponent<MeshRenderer>().enabled = false;
        meshObject3.GetComponent<MeshRenderer>().enabled = false;

        // Lógica para activar el mesh correspondiente
        switch (activationCount)
        {
            case 1:
                if (meshObject1 != null && meshBarrera1.GetComponent<MeshRenderer>().enabled == true)
                    meshObject1.GetComponent<MeshRenderer>().enabled = true;
                break;
            case 2:
                if (meshObject2 != null && meshBarrera2.GetComponent<MeshRenderer>().enabled == true)
                    meshObject2.GetComponent<MeshRenderer>().enabled = true;
                break;
            case 3:
                if (meshObject3 != null && meshBarrera3.GetComponent<MeshRenderer>().enabled == true)
                    meshObject3.GetComponent<MeshRenderer>().enabled = true;
                break;
            default:
                Debug.Log("More than three activations or none of the objects are assigned.");
                activationCount = 0;  // Reiniciar el contador para permitir cíclico
                break;
        }
    }
}
