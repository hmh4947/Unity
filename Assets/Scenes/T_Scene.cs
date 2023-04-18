using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    
   
    public void Change()
    {
       SceneManager.LoadScene("Main");
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
