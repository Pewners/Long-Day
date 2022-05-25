using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public GameObject text;
    bool textShown = false;

    public GameObject text2;

    public GameObject text3;
    bool textShown2 = false;

    public GameObject drug;

    public AudioSource source;
    public AudioClip mess;
    public AudioClip consider;
    public AudioClip amazing;


    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        //text2.SetActive(false);
        StartCoroutine(StartText());
    }

    // Update is called once per frame
    void Update()
    {
        if ((score > 5) && (textShown == false))
        {
            //play voice clip
            StartCoroutine(ShowText());
            _ = Instantiate(drug, new Vector3((float)-10.01, 1, (float)-36.75), Quaternion.identity);
        }

        if ((score > 9) && (textShown2 == false))
        {
            StartCoroutine(WorkText());
        }
    }

    IEnumerator ShowText() {
        textShown = true;
        text.SetActive(true);
        source.PlayOneShot(consider);
        yield return new WaitForSeconds(5f);
        text.SetActive(false);
    }

    IEnumerator StartText()
    {
        text2.SetActive(true);
        source.PlayOneShot(mess);
        yield return new WaitForSeconds(4f);
        text2.SetActive(false);
    }

    IEnumerator WorkText()
    {
        textShown2 = true;
        text3.SetActive(true);
        source.PlayOneShot(amazing);
        yield return new WaitForSeconds(3f);
        text3.SetActive(false);
    }
}
