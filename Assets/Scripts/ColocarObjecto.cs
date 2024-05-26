using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocarObjecto : MonoBehaviour
{
    public AudioSource audio;
    void Start() {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision) {
        if(gameObject.name=="Prefab_Pot_01"){
            if(collision.gameObject.name=="Prefab_Mushroom_01"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_02"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_03"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_04"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_05"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_06"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_07"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_08"){
                audio.Play();
            }
            else if(collision.gameObject.name=="Prefab_Mushroom_09"){
                audio.Play();
            }            
        }
    }
}
