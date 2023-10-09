using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio1 : MonoBehaviour
{ public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
