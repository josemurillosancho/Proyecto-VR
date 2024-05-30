using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Importar el espacio de nombres para trabajar con UI

public class PoopController : MonoBehaviour
{
    public List<GameObject> meshObjects = new List<GameObject>(); // Lista de objetos con MeshRenderer
    public List<GameObject> meshBarreras = new List<GameObject>(); // Lista de Barreras para cada mesh
    public GameObject cubetita; // La cubeta que el jugador interactúa

    public Button activationButton; // Botón de la interfaz de usuario para activar los objetos

    private int activationCount = 0;  // Contador para manejar las activaciones

    void Start()
    {
        // Asegúrate de asignar el botón en el Inspector de Unity
        activationButton.onClick.AddListener(HandleMeshActivation);
    }

    public void HandleMeshActivation()
    {
        int index = activationCount % meshObjects.Count; // Asegurar que el índice es cíclico dentro de la cantidad de objetos

        if (meshBarreras[index].GetComponent<MeshRenderer>().enabled)
        {
            meshObjects[index].GetComponent<MeshRenderer>().enabled = true; // Activa el objeto si su correspondiente barrera está activa
            cubetita.GetComponent<MeshRenderer>().enabled = false; // Opcional: desactivar la cubetita para simular que se vació
            activationCount++; // Incrementar solo si se activa un objeto
        }
        else
        {
            Debug.Log($"La barrera {index} no está activa, no se puede activar el objeto {index}.");
        }
    }

    void OnDestroy()
    {
        // Es buena práctica remover los listeners cuando el objeto se destruye
        activationButton.onClick.RemoveListener(HandleMeshActivation);
    }
}
