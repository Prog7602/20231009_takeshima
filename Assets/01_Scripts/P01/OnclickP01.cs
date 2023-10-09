using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickP01 : MonoBehaviour
{
    private GameObject text1;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        text1 = GameObject.Find("Text");
        text1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }  
    public void Onclick()
    {
        a++;

        if (a%2== 1)
        {
            text1.SetActive(true);
        }
        if (a%2== 0)
        {
            text1.SetActive(false);
        }
    }

}
