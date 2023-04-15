using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int bulletPower = 300;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObj = Instantiate(bulletPrefab, transform.position, transform.rotation);

            Vector3 vecBullet = new Vector3(0, 0, bulletPower);
            BulletController bulletControllerScr = bulletObj.GetComponent<BulletController>();
            bulletControllerScr.shootBullet(vecBullet);
        }
        

    }
  
}
