using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;



public class PalyerMove : MonoBehaviour
{
    private Camera camera;
    private NavMeshAgent agent;
    public Text text;
    private int cheeseCount = 0;
    
    void Start()
    {
        camera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        text.text = cheeseCount.ToString();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    public void ShowCheeseCount()
    {
        cheeseCount++;
        text.text = cheeseCount.ToString();
    }
}
