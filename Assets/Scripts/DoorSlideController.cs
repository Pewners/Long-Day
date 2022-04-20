using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSlideController : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door3")
        {
            instructions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Animator anim = other.GetComponentInChildren<Animator>();
                anim.SetTrigger("SlideOpenClose");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door3")
        {
            instructions.SetActive(false);
        }
    }
}
