using JetBrains.Annotations;
using Oculus.Platform.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ServerComputer : MonoBehaviour
{
    float fades = 0.0f;
    float time = 0;
    bool fadeinout = false;

    public GameObject server;
    public GameObject blueScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeinout)
        {
            fadeOut();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌");

        if(other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);

            GetComponent<AudioSource>().Play();

            server.SetActive(false);
            blueScreen.SetActive(true);

            fadeinout = true;
        }
    }

    void fadeOut()
    {
        time += Time.deltaTime;
        if (fades < 1.0f && time >= 0.1f)
        {
            fades += 0.1f;

            time = 0;
        }
        else if (fades >= 1.0f)
        {
            fadeinout = false;
            SceneManager.LoadScene("Stage3");
        }
    }
}
