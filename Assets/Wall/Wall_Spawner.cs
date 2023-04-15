using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Spawner : MonoBehaviour
{
    public GameObject WallPrefab;
    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateWall());
    }

    public float range = 20.0f;
    // Update is called once per frame

    IEnumerator CreateWall()
    { //돌아올 위치 기억
        WaitForSeconds wait = new WaitForSeconds(interval);
        while (true)
        {

            float WallPosZ = Random.Range(-range, range);
            transform.position = new Vector3(
                transform.position.x, WallPosZ, transform.position.z);

            Instantiate(WallPrefab, transform.position, transform.rotation);
            yield return wait;


        }
    }

    void Update()
    {
        
    }
    
}
    
