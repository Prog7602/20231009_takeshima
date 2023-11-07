using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_otokonoko : MonoBehaviour
{
    public Animator _animator;
    int level =-1;
    // Start is called before the first frame update
    void Start()
    {
        _animator.SetInteger("params", level);
        Debug.Log(level);
    }
    public void parans_up()
    {   
        level+=1;
        Debug.Log(level);
        _animator.SetInteger("params",level);
        if(level>=2)
        {
            level=0;
        }
    }

}
