using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Pickup : MonoBehaviour
{
    public int type = 0;

    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        if (other.tag == "Player")
        {
            Destroy(gameObject);

            if(type == 0)
            {
                PostProcessVolume grain = GameObject.Find("GrainPP").GetComponent<PostProcessVolume>();

                grain.enabled = true;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
