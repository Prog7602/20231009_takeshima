using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusuguriScript : MonoBehaviour
{
    public GameObject voice;
    public GameObject Canvas;
    private float flg = 0;

    public AudioClip kusugurisound;

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
        if (flg == 0)
        {
            GameObject voiceclone = Instantiate(voice, new Vector2(0f, 0f), Quaternion.Euler(0f, 0f, 0f));
            voiceclone.transform.SetParent(this.Canvas.transform, false);
            flg = 1;
            Invoke("count", 2f);

            audioSource.PlayOneShot(kusugurisound);

            Debug.Log("タッチされました");
        }
    }

    public void count()
    {
        flg = 0;
    }
}
