using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int scene;

    private void OnTriggerEnter(Collider other)
    {
        // Cargar la nueva escena
        SceneManager.LoadScene(scene);
    }
}
