using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public List<GameObject> cards;


    public void FlipCards(string name){
        Card card = CardControl(name);
        if (card!=null)
            card.Flip();
    }

    public void HideCards(){

    }

    public Card CardControl(string name){
        foreach(GameObject card in cards){
            if (card.name == name){
                return card.GetComponent<Card>(); 
                
            }
        }
        return null;
    }
}
