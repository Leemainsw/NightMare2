using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        // transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));

        GetComponent<Rigidbody>().AddForce(transform.right * bulletSpeed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
