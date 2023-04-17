using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void shootBullet(Vector3 vecBullet)
    {
        Rigidbody rigBody = GetComponent<Rigidbody>();
        rigBody.AddForce(vecBullet);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);

        }


    }
   
}
