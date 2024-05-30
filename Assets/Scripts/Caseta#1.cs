using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;



public class Jose : MonoBehaviour
{
public Animator animador;
public Animator animador1;
public AudioSource audioSource;
public GameObject plano;
public GameObject plano2;
public Material material_1;
public Material material_2;
public ParticleSystem particulas1;
    public void Presionar_abierto(){
        audioSource.Play();
        particulas1.Stop();
        animador.SetBool("test1",true);
        animador1.SetBool("arboles_1",true);
        Renderer rend = plano.GetComponent<Renderer>();
        rend.material = material_1;
        Renderer rend2 = plano2.GetComponent<Renderer>();
        rend2.material = material_2;
    }
}