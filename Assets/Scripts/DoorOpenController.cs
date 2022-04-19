using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpenController : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door2")
        {
            instructions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Animator anim = other.GetComponentInChildren<Animator>();
                anim.SetTrigger("OpenClose");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door2")
        {
            instructions.SetActive(false);
        }
    }
}
