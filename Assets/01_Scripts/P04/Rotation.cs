using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour

{
    public float rotation_speed = 0;// 回転速度
    public float upspeed = 0;
    private float time = 0f;
    private bool isCountdownStart;
    private static bool isQuitting = false;
    public AudioClip sound1;
    AudioSource audioSource;
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // 回転速度分回す
        //transform.Rotate(0, 0, this.rotation_speed);
        transform.Translate(0f, upspeed, 0f);

        if (isCountdownStart)
        {
            time += Time.deltaTime;
        }

        if (time >= 0.5f)
        {
            this.upspeed = 100f;
        } 
         if(this.transform.position.y >= 1000f)
        {
            this.upspeed = 0f;
            Debug.Log("1");
            time = 0;
            isCountdownStart = false;
        }
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    public void OnUserAction()
    {
        isCountdownStart = true;
        anim.SetTrigger("action");
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<AudioSource>().PlayOneShot(sound1);
        Invoke("delay",5f);
    }

    public void delay()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}