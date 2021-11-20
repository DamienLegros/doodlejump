using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class CameraGameOver : MonoBehaviour
{
    public AudioClip StartClip;
    public AudioClip LoopClip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playSound());
    }

    IEnumerator playSound()
    {
        GetComponent<AudioSource>().clip = StartClip;
        GetComponent<AudioSource>().Play();
        //yield return new WaitForSeconds(StartClip.length);
        yield return new WaitForSeconds(3);
        GetComponent<AudioSource>().clip = LoopClip;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
