using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public GameObject text;
    bool textShown = false;

    public GameObject text2;

    public GameObject drug;


    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        text2.SetActive(false);

        
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
    }

    IEnumerator ShowText() {
        textShown = true;
        text.SetActive(true);
        yield return new WaitForSeconds(3f);
        text.SetActive(false);
    }
}
