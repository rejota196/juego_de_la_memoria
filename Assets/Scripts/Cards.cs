using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public List<GameObject> cards;
    private int flippedCards;
    private GameObject card1 = null;
    private GameObject card2 = null;


    private void Update() {
        if(flippedCards>=2){
            if(card1.name==card2.name)
                Debug.Log("the cards are the same");
            else{
                StartCoroutine(Wait());
                
            }
                
        }
        Debug.Log(flippedCards);
        
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(2);
        HideCards();
                
    }

    public void FlipCards(GameObject newCard){
        Card cCard = CardControl(newCard);
        if(flippedCards<2){            
            if (cCard!=null &&!cCard.GetIsBloqued()){
                cCard.Flip();
                if(card1==null)
                    card1=newCard;
                else
                    card2=newCard;
                flippedCards++;    
            }
        }        
    }

    public void HideCards(){
        Card cCard = null;
        foreach(GameObject card in cards){
            cCard = card.GetComponent<Card>();
            cCard.Hide();
        }
        flippedCards = 0;
    }

    public Card CardControl(GameObject newCard){
        foreach(GameObject card in cards){
            Card cCard = card.GetComponent<Card>();
            Card cCard2 = newCard.GetComponent<Card>();
            if (cCard.GetId() == cCard2.GetId()){
                return card.GetComponent<Card>(); 
                
            }
        }
        return null;
    }
}
