using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Kirikae2_1 : MonoBehaviour
{
    public GameObject kemuri;
    public GameObject kemuri0;
    public GameObject kemuri2;
    bool a_flag;
    float timing = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        kemuri.SetActive(false);
        kemuri2.SetActive(false);
        kemuri0.SetActive(false);   
        a_flag = false;
    }
    public int a = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && a_flag == false)
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
        if (a_flag==true && a == 3 && Input.GetMouseButtonDown(0))
        {
            kemuri0.SetActive(true);
            kemuri.SetActive(true);
            kemuri2.SetActive(true);
        }
      

    }
}
