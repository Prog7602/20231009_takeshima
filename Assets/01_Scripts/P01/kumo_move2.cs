using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kumo_move2 : MonoBehaviour
{

    int SW = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (SW == 1)
        {
            gameObject.transform.Translate(-2.0f, 0.0f, 0.0f);
        }

    }

    // Update is called once per frame
    public void Move()
    {
        Debug.Log("acsses on2");
        SW = 1;
    }
}
