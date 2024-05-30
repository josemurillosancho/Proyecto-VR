using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcionesdemenu : MonoBehaviour
{
    public void CargarEscena(int numero)
    {

        SceneManager.LoadScene(numero);
    }

    public void Salir()
    {

        Application.Quit();
    }


}
