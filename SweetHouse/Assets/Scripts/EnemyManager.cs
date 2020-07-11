using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    private Transform _transform;
    private Transform playerTransform;
    private NavMeshAgent nvAgent;

    void Start()
    {
        _transform = this.gameObject.GetComponent<Transform>();
        playerTransform = GameObject.FindWithTag("player").GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();     
    }

    private void Update()
    {
        nvAgent.destination = playerTransform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Player과 귀신의 충돌 -> success 씬으로 이동
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        // Player과 귀신의 충돌 -> FAIL 씬으로 이동
        if(other.gameObject.tag == "Player")
        {
          //  SceneManager.LoadScene("Fail");
        }
    }
}
