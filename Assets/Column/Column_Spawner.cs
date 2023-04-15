using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Column_Spawner : MonoBehaviour
{
    public GameObject ColumnPrefab;
    public float interval;
    
 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateColumn()); //Coroutine을 사용하기 위한 등록 함수

    }

    public float range = 100.0f;

    IEnumerator CreateColumn() //돌아올 위치 기억
    {
        WaitForSeconds wait = new WaitForSeconds(interval);
        while (true)
        {
            
            float ColumnPosZ = Random.Range(-range, range);
            transform.position = new Vector3(
                ColumnPosZ, transform.position.y, transform.position.z);

            Instantiate(ColumnPrefab, transform.position, transform.rotation);
            yield return wait;


        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
