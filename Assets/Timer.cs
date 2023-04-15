using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;

   


    // Start is called before the first frame update
    void Start()
    {
      
    }
       
        // isGameover = false;
    

    // Update is called once per frame
    void Update()
    {

        LimitTime -= Time.deltaTime;
        text_Timer.text = "timer : " + Mathf.Round(LimitTime);

        if (LimitTime <= 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }


}