using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    private int count;
    //public static ScoreManager l;
    //public int Score;
   
    
    void Start()
    {
        //Score = 0;
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
}
