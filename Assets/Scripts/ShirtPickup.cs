using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtPickup : MonoBehaviour
{
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            score++;
        }
    }

    private void Update()
    {
        if (score > 3)
        {

        }
    }
}
