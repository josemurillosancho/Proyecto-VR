using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AserrinManager : MonoBehaviour
{
    public List<GameObject> meshObjects = new List<GameObject>(); // Lista de objetos con MeshRenderer
    public List<GameObject> meshBarreras = new List<GameObject>(); // Lista de Barreras para cada mesh
    public GameObject cubetita; // La cubeta que el jugador interactúa

    public XRSimpleInteractable simpleInteractable; // Componente Simple Interactable para la VR

    void Awake()
    {
        simpleInteractable = GetComponent<XRSimpleInteractable>();
        simpleInteractable.selectEntered.AddListener(StartInteraction);
        simpleInteractable.selectExited.AddListener(EndInteraction);
    }

    void StartInteraction(SelectEnterEventArgs args)
    {
        Debug.Log("Interaction Started");
    }

    void EndInteraction(SelectExitEventArgs args)
    {
        Debug.Log("Interaction Ended");
        HandleMeshActivation();
    }

    void HandleMeshActivation()
    {
        // Encuentra el índice del mesh actualmente activo
        int activeMeshIndex = meshObjects.FindIndex(mesh => mesh.GetComponent<MeshRenderer>().enabled);
        Debug.Log("     mesh activo " + activeMeshIndex);

        // Desactivar todos los mesh antes de activar el próximo
        foreach (var mesh in meshObjects)
        {
            mesh.GetComponent<MeshRenderer>().enabled = false;
        }

        // Determinar el próximo mesh a activar
        int nextMeshIndex = (activeMeshIndex + 1) % meshObjects.Count;

        // Si no hay ningún mesh activo actualmente, activa el primer mesh
        if (activeMeshIndex == -1)
        {
            meshObjects[0].GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            // Activar el siguiente mesh en la secuencia cíclica
            meshObjects[nextMeshIndex].GetComponent<MeshRenderer>().enabled = true;
        }

        // Desactivar la cubeta para simular que se vació
        cubetita.GetComponent<MeshRenderer>().enabled = false;
    }


    void OnDestroy()
    {
        if (simpleInteractable != null)
        {
            simpleInteractable.selectEntered.RemoveListener(StartInteraction);
            simpleInteractable.selectExited.RemoveListener(EndInteraction);
        }
    }
}
