using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour
{
    public int flg = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wait()
    {
        flg = 1;
        Invoke("count", 4.0f);
    }

    public void count()
    {
        flg = 0;
    }
}
