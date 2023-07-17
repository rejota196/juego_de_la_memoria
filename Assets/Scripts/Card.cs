using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Card : MonoBehaviour
{
    private Animator anim;
    private bool isRotated;
     
    void Start(){
        anim = GetComponent<Animator>();        
    }
    
    public void Flip(){
        if(!isRotated){
            anim.SetTrigger("ToShow");
            isRotated = true;    
        }
    }

    public void Hide(){
        if(isRotated){
            anim.SetTrigger("ToHide");
            isRotated = false;
        }
    }


}
