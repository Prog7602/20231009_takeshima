using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Kirikae : MonoBehaviour
{
    public Animation anim;
    public AudioClip audioClip;
    public SpriteRenderer Qtext;
    public bool a_flag;
    public bool a_flag1;
    float a_color;
    float timing = 0.0f;
   // float coumt_up;
    // Start is called before the first frame update
    void Start()
    {
        a_flag1 = true;
        a_flag = false;
        a_color = 0;
    }
    public int a = 0;
    public int b = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && a_flag ==false)
        {
            a_flag = true;
            ++a;
        }
        if (a_flag1==true && a==1 && Input.GetMouseButtonDown(0))
        {
            a_flag1 = false;
            if(anim != null){
            this.anim.Play();
            }
            if(this.GetComponent<AudioSource>() != null){
            this.GetComponent<AudioSource>().PlayOneShot(audioClip);
            }
        }
       
    if (a_flag == true && a == 1)
        {
            Qtext.color = new Color(255, 255, 255, a_color);
            timing++;
            a_color += 2*0.01f;
            if (timing>=100.0f)
            {
                a_flag1 = true;
                a_flag = false;
            }
        }
        if (a_flag==true && a>=2)
        {
         
            Qtext.color = new Color(255, 255, 255, 0);

        }

    }
}