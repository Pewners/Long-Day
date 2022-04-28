using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    //    public GameObject instructions;
    //    private void OnTriggerStay(Collider other)
    //    {
    //        if (other.tag == "Door")
    //        {
    //            instructions.SetActive(true);
    //            if (Input.GetKeyDown(KeyCode.E))
    //            {
    //                SceneManager.LoadScene(3);
    //            }
    //        }
    //    }

    //    private void OnTriggerExit(Collider other)
    //    {
    //        if (other.tag == "Door")
    //        {
    //            instructions.SetActive(false);
    //        }
    //    }
    public GameObject instructions;
    //Animator anim;
    bool inTrigger = false;
    bool doorOpen = false;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (inTrigger == true)
        {
            //Debug.Log("in trigger");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("e pressed");
                SceneManager.LoadScene(3);

                doorOpen = !doorOpen;
            }

        }

        //anim.SetBool("Open", doorOpen);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            instructions.SetActive(true);
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            instructions.SetActive(false);
            inTrigger = false;
        }
    }
}
