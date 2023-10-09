using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Kirikae2 : MonoBehaviour
{
    public GameObject kemuri1;
    public AudioClip audioClip;
    public SpriteRenderer Qtext;
    bool a_flag;
    bool a_flag1;
    float timing = 0.0f;
    float a_color;
    // Start is called before the first frame update
    void Start()
    {
        if(kemuri1 != null){
        kemuri1.SetActive(false);
        }
        a_flag = false;
        a_flag1 = true;
        a_color = 0;
    }
    public int a = 0;
    public int b = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)  && a_flag == false)
        {
            timing = 0.0f;
            a++;
            a_flag = true;
        }
        else if (a_flag == true && a <= 2)
        {
            timing++;
            if (timing == 100.0f)
            {
                a_flag = false;
            }
        }
        if (a_flag1==true && a == 3 && Input.GetMouseButtonDown(0))
        {
            a_flag1 = false;
            this.GetComponent<AudioSource>().PlayOneShot(audioClip);
            if(kemuri1 != null){
            kemuri1.SetActive(true);
            }
        }
            if (a_flag==true && a==3)
        {
            timing++;
            Qtext.color = new Color(255, 255, 255, a_color);
            a_color += Time.deltaTime;
       
        

        }

    }
}
