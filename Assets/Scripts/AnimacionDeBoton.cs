using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimacionDeBoton : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Animador;
    public AudioSource audioSource;

    // Update is called once per frame
    public void Presionar(){
        Animador.SetBool("PressButton", true);
        audioSource.Play();
    }

    public void NoPresionar(){
        Animador.SetBool("PressButton", false);
    }
}