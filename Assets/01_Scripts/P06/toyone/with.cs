using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class with : MonoBehaviour
{
    public Transform boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
  
     this.transform.position = new Vector3(boss.transform.position.x,this.transform.position.y,0);
    }
}
