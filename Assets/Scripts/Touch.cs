using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touch : MonoBehaviour
{
    public GameObject box;
    public GameObject text;
    bool textShown = false;

    private void Start()
    {
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Touch");
            Destroy(gameObject);
            StartCoroutine(Home());
        }
    }

    IEnumerator Home()
    {
        textShown = true;
        text.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(4);
    }
}
