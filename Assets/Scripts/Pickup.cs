using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Pickup : MonoBehaviour
{
    public gameObject speed;

    private void Start()
    {
    //    speed = GameObject.Find ("CharacterController").GetComponent<normalSpeed>();
    }

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

            if (type == 1)
            {
                PostProcessVolume lol = GameObject.Find("Volume").GetComponent<PostProcessVolume>();

                lol.enabled = true;

                PostProcessVolume ye = GameObject.Find("yea").GetComponent<PostProcessVolume>();

                ye.enabled = false;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class gameObject
{
}