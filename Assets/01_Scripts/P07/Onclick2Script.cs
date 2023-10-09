using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using next;

public class Onclick2Script : MonoBehaviour
{
    public AudioClip audioClip;
    public GameObject gameobject;
    public SpriteRenderer spriteRenderer;
    public int a=8;
    Animation anim;
    bool a_flag;
    float countup = 0.0f;
    //float a_color;
    //Animation anim2;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameobject.GetComponent<Animation>();
        //anim2 = this.gameobject.GetComponent<Animation>("onsenAnimation2");
        a_flag = false;
        a = 8;
        //a_color = 0;
        //spriteRenderer.color = new.Color(255, 255, 255, a_color);

    }
    // Update is called once per frame
    void Update()
    {
        countup += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            a++;
            if (countup>=2.0)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audioClip);
                countup = 0.0f;
            }
        }
        if ((a == 0||a==9) && Input.GetMouseButtonDown(0))
        {
            a_flag = true;
            anim.Play("onsennAnimatui");
            //a_color = 255;
        }
        a_flag = false;

        if (a == 1 && Input.GetMouseButtonDown(0))
        {
            a_flag = true;
            anim.Play("onsenAnimation");
        }
        a_flag = false;
        if (a == 2)
        {
        }

        if (a == 3 && Input.GetMouseButtonDown(0))
        {
            a_flag = true;
            anim.Play("onsenAnimation2");
        }
        if (a == 4 && Input.GetMouseButtonDown(0))
        {
            anim.Play("onsennAnimation3");
            a_flag = false;
        }

        if ((a == 5 || a == 7) && Input.GetMouseButtonDown(0))
        {
            anim.Play("onsennAnimation4");
        }
        if (a == 6 && Input.GetMouseButtonDown(0))
        {
            anim.Play("onsennAnimation3");
        }
        if (a == 7)
        {
            a = 5;
        }
        if (a == 8)
        {
        }
        if (a == 9)
        {
            a = 0;
        }
    }
}
