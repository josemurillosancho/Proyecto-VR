using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocarTapa : MonoBehaviour
{
    public AudioSource audio;
    void Start() {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision) {


        if(gameObject.name=="Prefab_Pot_Cover"){
            if(collision.gameObject.name=="Prefab_Pot_01"){
                audio.Play();
            }
        }
    }
}