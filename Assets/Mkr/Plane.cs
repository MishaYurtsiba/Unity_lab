using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] private float spead;
    [SerializeField] private GameObject player ;
    [SerializeField] private Transform cam;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(0,0,spead *Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            player.SetActive(true);
            Camera.main.transform.position = cam.transform.position;
            cam.SetParent(player.transform);
        }
    }
}
