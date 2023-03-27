using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    [SerializeField] private float timer = 0;
    [SerializeField] private float waitingWtime = 5; 
    private Camera camera;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingWtime)
        {
            agent.SetDestination(player.position);
        }
        transform.rotation =player.transform.rotation;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}