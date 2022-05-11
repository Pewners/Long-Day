using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShirtPickup : MonoBehaviour
{
    public static int score = 0;

    public Text test;

    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            score += 1;
            Debug.Log(score);
        }
    }

    void Start()
    {
        //Text.SetActive(false);
    }

    private void Update()
    {
        if (score > 3)
        {
            //play voice clip
            
        }
    }
}
