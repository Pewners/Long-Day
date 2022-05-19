using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperPickup : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text test;

    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        if (other.tag == "Player")
        {
            
            scoreManager.score += 1;
            Debug.Log(scoreManager.score);
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Text.SetActive(false);
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        
    }
}
