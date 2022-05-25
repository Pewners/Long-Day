using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touch : MonoBehaviour
{
    public GameObject box;
    public GameObject text;
    public AudioSource source;
    public AudioClip forgetThis;
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
        source.PlayOneShot(forgetThis);
        yield return new WaitForSeconds(4f);
        Debug.Log("Wait finished");
        SceneManager.LoadScene(4);
    }
}
