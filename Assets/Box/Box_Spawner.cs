using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Spawner : MonoBehaviour
{
    public GameObject BoxPrefab;
    private float timeCount = 0.0f;
  //  public float interval;
   // public float range = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Random.Range(-3.4f, 1.5f);
        float zPos = Random.Range(-37.0f, -11.0f);
        Vector3 randomPos = new Vector3(xPos, 9.0f,zPos);

        timeCount += Time.deltaTime;
        if (timeCount > 1.0f)
        {
            Debug.Log("생성");
            Instantiate(BoxPrefab, randomPos, transform.rotation);
            timeCount = 0.0f;

        }
        else if (timeCount >13.0f)
        {
            Debug.Log("삭제");
            Destroy(gameObject);
        }

        // timeCount += Time.deltaTime;
    }
    
   
        
}
