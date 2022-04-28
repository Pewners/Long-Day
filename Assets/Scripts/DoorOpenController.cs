using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpenController : MonoBehaviour
{
//    public GameObject instructions;
//    private void OnTriggerStay(Collider other)
//    {
//        if (other.tag == "Door2")
//        {
//            instructions.SetActive(true);
//            if (Input.GetKeyDown(KeyCode.E))
//            {
//                Animator anim = other.GetComponentInChildren<Animator>();
//                anim.SetTrigger("OpenClose");
//            }
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if (other.tag == "Door2")
//        {
//            instructions.SetActive(false);
//        }
//    }

public GameObject instructions;
    Animator anim;
    bool inTrigger = false;
    bool OpenClose = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update() {
        if (inTrigger == true) 
        {
            //Debug.Log("in trigger");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("e pressed");

                OpenClose = !OpenClose;
            }

        }

        anim.SetBool("OpenClose", OpenClose);
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
