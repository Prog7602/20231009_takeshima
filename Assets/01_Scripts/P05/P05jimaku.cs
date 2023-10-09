using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P05jimaku : MonoBehaviour
{
    int flg;
   public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        flg = 1;
    }

    public void OnClick()
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
