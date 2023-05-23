using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cheese : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PalyerMove>(out PalyerMove player))
        {
            Debug.Log("ddd");
            player.ShowCheeseCount();
            Destroy(gameObject);
        }
    }
}
