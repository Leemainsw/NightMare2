using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageBar : MonoBehaviour
{
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Gun3;

    public GameObject PlayerGun;

    bool[] FindGun = new bool[3];
    private float value = 0f;

    public GameObject GunPart1;
    public GameObject GunPart2;
    public GameObject GunPart3;

    // Start is called before the first frame update
    void Start()
    {
        // player Gun 비활성화
        PlayerGun.SetActive(false);

        // gun 부품 찾았는지 조건 
        for (int i=0; i<3; i++)
        {
            FindGun[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            value += 0.1f;
        }

        if(FindGun[0] && FindGun[1] && FindGun[2])
        {
            PlayerGun.SetActive(true);
        }
    }

    void OnTriggerStay(Collider col)
    {
        Debug.Log(col);
        if (col.gameObject.tag == "Gun1" || col.gameObject == Gun1.gameObject)
        {
            Debug.Log("Gun1과 충돌");
            if (value < 30)
            {
                //if (Input.GetKey(KeyCode.Z))
                //{
                //    value += 0.1f;
                //}
            }

            else
            {
                FindGun[0] = true;
                Debug.Log("Find Gun1");
                value = 0;
                col.gameObject.SetActive(false);
                GunPart1.SetActive(false);
            }

        }

        else if(col.gameObject.tag == "Gun2" || col.gameObject == Gun2.gameObject)
        {
            Debug.Log("Gun2과 충돌");
            if (value < 30)
            {
                //if (Input.GetKey(KeyCode.Z))
                //{
                //    value += 0.1f;
                //}
            }

            else
            {
                FindGun[1] = true;
                Debug.Log("Find Gun2");
                value = 0;
                col.gameObject.SetActive(false);
                GunPart2.SetActive(false);
            }
        }

        else if(col.gameObject.tag == "Gun3" || col.gameObject == Gun3.gameObject)
        {
            Debug.Log("Gun3과 충돌");
            if (value < 30)
            {
                //if (Input.GetKey(KeyCode.Z))
                //{
                //    value += 0.1f;
                //}
            }

            else
            {
                FindGun[2] = true;
                Debug.Log("Find Gun3");
                value = 0;
                col.gameObject.SetActive(false);
                GunPart3.SetActive(false);
            }
        }
    }
}

