using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kumo_move_last_right : MonoBehaviour
{
    int SW = 0;
    GameObject AB;
    private bool isCountdownStart;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        AB = GameObject.Find("kumo_right_2");
    }

    void Update()
    {
        if (isCountdownStart)
        {
            time += Time.deltaTime;
        }
        if (time >=1.0f)
        {
            SW = 1;
        }
    }

    void FixedUpdate()
    {
        
        if (gameObject.transform.position.x <= 435.0f)
        {
            SW = 0;
            isCountdownStart = false;
        }
        if (SW == 1)
        {
            gameObject.transform.Translate(-2.0f, 0.0f, 0.0f);
        }
        
    }
    public void Move()
    {
        Debug.Log("acsses on1");
        isCountdownStart = true;
        
    }
    
}