using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Kirikae1 : MonoBehaviour
{
    public AudioClip audioClip;
    public SpriteRenderer Qtext;
    bool a_flag;
    public bool a_flag1;
    float a_color;
    float timing = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        a_flag = false;
        a_color = 0;
    }
    public int a = 0;
    public int b = 0;
        // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && a_flag == false)
        {
            a++;
            a_flag = true;
        } else if(a_flag==true && a==1){ 
            timing++;
            if (timing == 100.0f){ a_flag = false;
                a_flag1 = true;       
            }
        } 
        if (a_flag1==true && a == 2 && Input.GetMouseButtonDown(0))
        {
            timing = 0.0f;
            a_flag1 = false;
            if(this.GetComponent<AudioSource>() != null){
            this.GetComponent<AudioSource>().PlayOneShot(audioClip);
            }
        }
            if (a_flag==true && a == 2)
            {
            timing++;
            Qtext.color = new Color(255, 255, 255, a_color);
            a_color += 3*Time.deltaTime;
       
            if (timing >= 100.0f)
            {
                a_flag1 = true;
                a_flag = false;
            }

            }
        if (a_flag==true && a>=3)
        {
         
            Qtext.color = new Color(255, 255, 255, 0);

        }

    }
}
