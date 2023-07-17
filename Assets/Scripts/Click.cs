using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    
    [SerializeField]
    private Cards cards;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Card") 
                {
                    string name = hit.collider.gameObject.name;
                    cards.FlipCards(name);                                               
                    
                }
            }
        }
    }
}
