using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respown : MonoBehaviour
{
    public GameObject[]  bowl;
    //public GameObject[] countinuePoint;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void respownproject()
    {
        
        Instantiate(bowl[0], transform.position, transform.rotation);
    }
}
