using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dfsfrgfrgf : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
        StartCoroutine(yea());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator yea()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(3f);
        text.SetActive(false);
    }
}
