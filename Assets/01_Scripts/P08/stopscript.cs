using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopscript : MonoBehaviour
{
    
    public GameObject Cube3;

    // Start is called before the first frame update
    void Start()
    { 
        


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Cube3.SetActive(false);
            Invoke("Call", 2f);
        }
    }

    void Call()
    { 
            Cube3.SetActive(true);  
    }
   
}
