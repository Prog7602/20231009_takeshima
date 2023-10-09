using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class deth : MonoBehaviour
{
    public float deleteTime = 1.0f;
    bool delete = true;
    public float Height = 342f;

    // Use this for initialization
    void Start()
    {


        
        //Destroy(gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (delete = true && transform.position.y < Height)
        {
            Destroy(gameObject, deleteTime);
        }
    }
   
}
