using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch1 : MonoBehaviour
{
    public GameObject box;
    public GameObject text;
    public AudioSource source;
    public AudioClip bed;
    //bool textShown = false;

    private void Start()
    {
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Touch");
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine(Home());
        }
    }

    IEnumerator Home()
    {
        //textShown = true;
        text.SetActive(true);
        source.PlayOneShot(bed);
        yield return new WaitForSeconds(2f);
        text.SetActive(false);
    }
}
