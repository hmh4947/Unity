using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



/*public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    private int count;
    // public static ScoreManager l;
    public int Score;
   
    
    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        GameObject scoreObj = GameObject.Find("Score");
        this.scoreText = scoreObj.GetComponent<Text>(); // Text object ã��
        count = 0; // ���� �ʱ�ȭ

        
    }
    public void incScore()
    {
        count += 1;
        this.scoreText.text = count.ToString();  // ���ڸ� ���ڿ��� ��ȯ �� Text�� ����
    }

}*/
//using TMPro;

public class ScoreManager : MonoBehaviour
{
   


    public Text scoreText;
    private float score;
    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
      //  go = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(go != null)
        {
            score += Time.deltaTime;
            text.text = ((int)score).ToString();
            this.scoreText.text = ((int)score).ToString();
           
        }
    }
}

