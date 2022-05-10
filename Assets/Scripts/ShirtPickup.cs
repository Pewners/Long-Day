using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
