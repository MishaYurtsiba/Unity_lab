using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] private Vector3 offset;
    [SerializeField] private float spead;
    private Transform cam;
    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        transform.Translate(0, 0, spead * Time.deltaTime);
        cam.transform.position = transform.position + offset; 
    }
}
