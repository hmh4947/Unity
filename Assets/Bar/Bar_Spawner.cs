using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bar_Spawner : MonoBehaviour
{
    public GameObject BarPrefab;
    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateBar());
    }

    public float range = 20.0f;

    IEnumerator CreateBar() //돌아올 위치 기억
    {
        WaitForSeconds wait = new WaitForSeconds(interval);
        while (true)
        {

            float BarPosZ = Random.Range(-range, range);
            transform.position = new Vector3(
                transform.position.x, BarPosZ, transform.position.z);

            Instantiate(BarPrefab, transform.position, transform.rotation);
            yield return wait;


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
