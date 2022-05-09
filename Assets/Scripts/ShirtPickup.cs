using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtPickup : MonoBehaviour
{
    int shirts = 0;
    
    void Start() 
    {
        
    }
    
    //private void OnTriggerEnter(Collider obj)
    //{
    //    if (obj.gameObject.CompareTag("Shirts"))
    //    {
    //        shirts++;
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Shirts")
        {
            Destroy(gameObject);
        }

    }
}
