using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_ : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool is_text_displayed = true;

    public void Start()
    {
        gameObject.SetActive(is_text_displayed);
    }

    public void toggle ()
    {
        if(is_text_displayed==true){
            is_text_displayed=false;
        }else if(is_text_displayed==false){
            is_text_displayed=true;
        }
        Debug.Log(is_text_displayed);
    }
    
    public void pxx_text()
    {
        toggle();
        gameObject.SetActive(is_text_displayed);
    }
    
}
