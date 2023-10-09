using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_script : MonoBehaviour
{
    public  GameObject text;
    private int flg;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        flg = 1;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void Click()
    {
      
        
            if (flg == 1)
            {
                text.SetActive(true);
                flg = 0;
            }
            else if (flg == 0)
            {
                text.SetActive(false);
                flg = 1;
            }
       
    }
}
