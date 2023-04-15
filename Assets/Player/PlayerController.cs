using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
    
{

    
  
    float speed = 3.0f;
    

    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {


        if (Input.GetKey(KeyCode.S)) //이동back
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)) //이동forward
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) //이동L
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) //이동R
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
       
    }
}
