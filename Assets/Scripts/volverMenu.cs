using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volverMenu : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(0);
    }
}