using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Card : MonoBehaviour
{
    [SerializeField]
    private int id;
    private bool isBlocked;
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

    public void BlockCard(){
        isBlocked = true;
    }

    public bool GetIsBloqued(){
        return isBlocked;
    }

    public int GetId(){
        return id;
    }

    public bool GetIsRotated(){
        return isRotated;
    }


}
