using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcionesMenu : MonoBehaviour
{
    public void cargarEscena(int numero) {
        SceneManager.LoadScene(numero);
    }
}
