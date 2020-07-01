using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageBar : MonoBehaviour
{

    // z 누르는 if문을 그 컨트롤러 누를 때로 변경하면 됨
    public Slider Bar;

    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Gun3;

    public Text EnemyForPlayer;

    bool[] FindGun = new bool[3];

    private GameObject GunEvent;
    // Start is called before the first frame update
    void Start()
    {
        GunEvent = GameObject.Find("GunEvent");
        GunEvent.SetActive(false);

        for(int i=0; i<3; i++)
        {
            FindGun[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            Bar.value += 0.1f;
        }

        if(FindGun[0] && FindGun[1] && FindGun[2])
        {
            EnemyForPlayer.text = "부품을 다 찾았습니다!\n 귀신을 쏘고 이 방을 탈출하세요!";
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Gun1")
        {
            GunEvent.SetActive(true);

            if (Bar.value < 30)
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    Bar.value += 0.1f;
                }
            }

            else
            {
                FindGun[0] = true;
                Debug.Log("Find Gun1");
                Bar.value = 0;
                GunEvent.SetActive(false);
                col.gameObject.SetActive(false);
            }

        }

        else if(col.gameObject.tag == "Gun2")
        {
            GunEvent.SetActive(true);

            if (Bar.value < 30)
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    Bar.value += 0.1f;
                }
            }

            else
            {
                FindGun[1] = true;
                Debug.Log("Find Gun2");
                Bar.value = 0;
                GunEvent.SetActive(false);
                col.gameObject.SetActive(false);
            }
        }

        else if(col.gameObject.tag == "Gun3")
        {
            GunEvent.SetActive(true);

            if (Bar.value < 30)
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    Bar.value += 0.1f;
                }
            }

            else
            {
                FindGun[2] = true;
                Debug.Log("Find Gun3");
                Bar.value = 0;
                GunEvent.SetActive(false);
                col.gameObject.SetActive(false);
            }
        }
    }
}

