using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class Caseta_2 : MonoBehaviour
{
    public ParticleSystem particulas1;
    public ParticleSystem particulas2;
    public ParticleSystem particulas3;
    public Animator animador;
    public GameObject plano;
    public Material material_1;
    int canno1 = 0;
    int canno2 = 0;
    int canno3 = 0;
    public void Boton_1(){
        if(canno1 == 0){
            particulas1.Stop();
            canno1 = 1;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }else{
            particulas1.Play();
            canno1 = 0;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }
        if(canno2 == 0){
            particulas2.Stop();
            canno2 = 1;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }else{
            particulas2.Play();
            canno2 = 0;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }        
    }
    public void Boton_2(){
        if(canno2 == 0){
            particulas2.Stop();
            canno2 = 1;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }else{
            particulas2.Play();
            canno2 = 0;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }
        if(canno3 == 0){
            particulas3.Stop();
            canno3 = 1;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }else{
            particulas3.Play();
            canno3 = 0;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }        
    }
    public void Boton_3(){
        if(canno3 == 0){
            particulas3.Stop();
            canno3 = 1;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }else{
            particulas3.Play();
            canno3 = 0;
            if(canno1 == 1 & canno2 == 1 & canno3 == 1){
                animador.SetBool("puerta2",true);
                Renderer rend = plano.GetComponent<Renderer>();
                rend.material = material_1;
            }
        }        
    }
}