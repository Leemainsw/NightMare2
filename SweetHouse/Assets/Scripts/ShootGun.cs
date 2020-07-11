
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public Transform firepos;
    public GameObject bullet;

    private GameObject currentBullet;
    private float shootTime = 0.0f;

    private Animator anim;

    public AudioSource audioSource;
    public AudioClip shootClip;

    int bulletCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        shootTime = 0;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        shootTime += Time.deltaTime;
        if((OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.Z)) && bulletCount<6)
        {
            if(shootTime>0.5f)
            {
                Shoot();
            }
        }

        // 장전
        if (bulletCount >= 6)
        {
            bulletCount = 0;
        }
    }

    void Shoot()
    {
        bulletCount++;

        currentBullet = Instantiate(bullet, firepos.transform.position, firepos.transform.rotation);

        audioSource.Play();
        shootTime = 0.0f;

        Destroy(currentBullet, 3);
    }
}
