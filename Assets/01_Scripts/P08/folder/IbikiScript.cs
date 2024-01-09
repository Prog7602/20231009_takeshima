using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IbikiScript : MonoBehaviour
{
    public GameObject voice;
    public GameObject Canvas;
    public Wait Wcs;

    public AudioClip ibikisound;

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

    public void OnHeadTouched()
    {
        if (Wcs.flg == 0)
        {
            GameObject voiceclone = Instantiate(voice, new Vector2(0f, 0f), Quaternion.Euler(0f, 0f, 90f));
            //voiceclone.transform.SetParent(this.Canvas.transform, false);

            Wcs.wait();

            audioSource.PlayOneShot(ibikisound);
        }
    }
}
