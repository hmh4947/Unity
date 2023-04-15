using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 40f);
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
