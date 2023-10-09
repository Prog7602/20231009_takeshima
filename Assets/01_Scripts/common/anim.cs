using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    Animation an;
    public GameObject gameobject;
    public GameObject gameobject2;
    bool is_enabled_home_button =true;
   
    int level =0;
    float speed;
    void Start()
    {
        an=this.gameobject.GetComponent<Animation>();
        gameobject2.SetActive(false);
    }
    public void animationCC()
    {
       if(is_enabled_home_button){
           is_enabled_home_button = false;
           an.Play("dialog_Animation");
           gameobject2.SetActive(true);
       }
        

    }
    public void animationC()
    {
        an.Play("dialog_Animation2");
        is_enabled_home_button = true;
        gameobject2.SetActive(false);

    }
    
    // Start is called before the first frame update
    /*void Start()
    {
        _animator.SetInteger("params", level);
        Debug.Log(level);
       
    }
    public void parans_up()
    {   speed=1.0f;
        level+=1;
        Debug.Log(level);
        _animator.SetInteger("params",level);
        if(level>=1)
        {
            level=0;
        }
        _animator.SetFloat("speed",speed);
    }
    public void params_reverse()
    {
        speed = -10.0f;
        _animator.SetFloat("speed",speed);
    }
    */

}
