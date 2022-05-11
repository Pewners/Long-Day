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
        if ((score > 3) && (textShown == false))
        {
            //play voice clip
            StartCoroutine(ShowText());
            _ = Instantiate(drug, new Vector3((float)-10.01, 1, (float)-36.75), Quaternion.identity);
        }

        if ((score > 10) && (textShown2 == false))
        {
            StartCoroutine(WorkText());
        }
    }

    IEnumerator ShowText() {
        textShown = true;
        text.SetActive(true);
        yield return new WaitForSeconds(3f);
        text.SetActive(false);
    }

    IEnumerator StartText()
    {
        text2.SetActive(true);
        yield return new WaitForSeconds(3f);
        text2.SetActive(false);
    }

    IEnumerator WorkText()
    {
        textShown2 = true;
        text3.SetActive(true);
        yield return new WaitForSeconds(3f);
        text3.SetActive(false);
    }
}
