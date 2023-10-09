using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x_axis_up : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform effict;
    public AudioClip sound1; 
    AudioSource audioSource;

   

    public int flag_int = 0;
    private bool flag = true; 

    public void Event()
    {
        audioSource = GetComponent<AudioSource>();

        SpriteRenderer s = effict.gameObject.GetComponent<SpriteRenderer>();
        
        if(flag_int==3){ 
            audioSource.PlayOneShot(sound1);
            return ;
        }
        Debug.Log("イベント発生！");
        if(flag){
            s.sortingOrder =5;
            if(flag_int==1){
                effict.transform.position =  new Vector3(effict.transform.position.y-200,-300,0);
            }else{ 
                effict.transform.position =  new Vector3(effict.transform.position.y,400,0);
                Debug.Log(effict.transform.position);
        }
        audioSource.PlayOneShot(sound1);
        flag=false;
        }else
        {
            s.sortingOrder = 0;
        effict.transform.position =  new Vector3(effict.transform.position.y,30,0);
        Debug.Log(effict.transform.position) ;
        flag=true;
        }
        
        
    }


    

    // Update is called once per fr
}
