using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public AudioClip clip1;
    public AudioClip clip2;

    private void Start()
    {
        source.PlayOneShot(clip);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(clip1);
        //    source.PlayOneShot(clip2);
        }
    }
}
