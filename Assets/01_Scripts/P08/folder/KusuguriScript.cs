using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusuguriScript : MonoBehaviour
{
    public GameObject voice;
    public GameObject man;
    public Wait Wcs;

    public AudioClip sound;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Onfoot2Touched()
    {
        if (Wcs.flg == 0)
        {
            GameObject voiceclone = Instantiate(voice, new Vector2(0f, 0f), Quaternion.Euler(0f, 0f, 0f));
            //voiceclone.transform.SetParent(this.man.transform, false);

            Wcs.wait();

            audioSource.PlayOneShot(sound);
        }
    }
}
