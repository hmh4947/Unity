using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Column : MonoBehaviour
{
    public float speed;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Main");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, 30f);


    }
   
    
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(speed * Time.deltaTime, 0, 0); //
    }
}
