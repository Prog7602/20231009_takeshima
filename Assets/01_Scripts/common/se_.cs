using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class se_ : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool is_text_displayed=true;
    AudioSource my_se;
    public void Start()
    {
        if(this.GetComponent<AudioSource> ()!= null){
            my_se = GetComponent<AudioSource>();
            my_se.enabled=is_text_displayed;
        }else{
            Debug.Log("this sprite have no AudioSource");
        }
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
        
        
    }
    
}
