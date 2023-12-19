using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootScript : MonoBehaviour
{
    private Animator anim;
    private Animator anim2;

    public GameObject[] movefoot;

    private float flg = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = movefoot[0].GetComponent<Animator>();
        anim2 = movefoot[1].GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void foot()
    {
        if (flg == 0)
        {
            anim.SetBool("disappear", true);
            anim2.SetBool("disappear", true);
            flg = 1;
            Invoke("end", 1.9f);
        }
    }

    public void end()
    {
        flg = 0;
        anim.SetBool("disappear", false);
        anim2.SetBool("disappear", false);
    }
}
