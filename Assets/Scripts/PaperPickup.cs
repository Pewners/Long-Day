using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperPickup : MonoBehaviour
{
    public ScoreManagerWork scoreManagerWork;
    public Text test;

    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        if (other.tag == "Player")
        {
            
            scoreManagerWork.score += 1;
            Debug.Log(scoreManagerWork.score);
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Text.SetActive(false);
        scoreManagerWork = FindObjectOfType<ScoreManagerWork>();
    }

    private void Update()
    {
        
    }
}
