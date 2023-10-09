using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kumo_move : MonoBehaviour
{
    int SW = 0;
    GameObject AB;


    // Start is called before the first frame update
    void Start()
    {
        AB = GameObject.Find("kumo_right_2");
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(SW == 1)
        {
        gameObject.transform.Translate(2.0f, 0.0f, 0.0f);
            Mathf.Clamp(0, 0,0);
        }
       
    }

    // Update is called once per frame
    public void Move()
    {
        Debug.Log("acsses on");
        SW = 1;
    }
}
