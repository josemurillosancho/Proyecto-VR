using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;


public class Jose : MonoBehaviour
{
public Animator animador;
public GameObject plano;
public Material material_1;
public ParticleSystem particulas1;
    public void Presionar_abierto(){
        particulas1.Stop();
        animador.SetBool("test1",true);
        Renderer rend = plano.GetComponent<Renderer>();
        rend.material = material_1;
    }
}