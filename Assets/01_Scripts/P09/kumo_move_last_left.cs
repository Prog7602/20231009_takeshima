using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kumo_move_last_left : MonoBehaviour
{
    int SW = 0;
    private bool isCountdownStart;
    float time;
    float interval = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isCountdownStart)
        {
            time += Time.deltaTime;
        }
        if (time >= interval)
        {
            SW = 1;
        }
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.x >= -85.0f)
        {
            SW = 0;
            isCountdownStart = false;
        }
        if (SW == 1)
        {
            gameObject.transform.Translate(3.0f, 0.0f, 0.0f);
        }
        
    }

    // Update is called once per frame
    public void Move()
    {
        Debug.Log("acsses on2");
        isCountdownStart = true;
    }
}

