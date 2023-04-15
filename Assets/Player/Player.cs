using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    public float jumpPower;
    public float speed = 5.0f;


    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {

            case "Finish":

            SceneManager.LoadScene("Finish_scene");
                break;

            case "Obstacle":

            SceneManager.LoadScene("Main");
                break;

        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }
  
    // Update is called once per frame
    void Update()
    {

       


        if (Input.GetButtonDown("Jump")) //캐릭터 점프
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //이동L
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) //이동R
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
      
    }

   
}
