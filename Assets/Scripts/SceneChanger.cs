using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneChanger : MonoBehaviour
{
    void Start()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(sceneIndex);
    }    
    
}
