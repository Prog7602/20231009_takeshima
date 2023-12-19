using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IbikiScript : MonoBehaviour
{
    public GameObject voice;
    public GameObject Canvas;
    private float flg = 0;

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
        if (flg == 0)
        {
            GameObject voiceclone = Instantiate(voice, new Vector2(50f, 20f), Quaternion.Euler(0f, 0f, 90f));
            voiceclone.transform.SetParent(this.Canvas.transform, false);
            flg = 1;
            Invoke("count", 2f);

            audioSource.PlayOneShot(ibikisound);
        }
        //Debug.Log("タッチされました");
    }

    public void count()
    {
        flg = 0;
    }
}
