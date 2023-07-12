using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    public AudioSource audio;
    public GameObject sceneChanger;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void ClickOnPlay(){
        audio.Play();
        StartCoroutine(Wait());
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(0.5f);
        sceneChanger.SetActive(true);
    }

    
}
