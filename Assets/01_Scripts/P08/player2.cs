using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    Rigidbody2D rigit2D;
    private float jumpPower = 1000.0f;
    public float Height = 341f;
    private Animator anim = null;
    private int Number = 0;
    private bool flg = true;
    public GameObject Cube3;

    // Use this for initialization
    void Start()
    {
        this.rigit2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        // ジャンプさせる
        /*if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("start");
            if (flg == true)
            {
                GetComponent<AudioSource>().Play();
                flg = false;
            }

            if (transform.position.y < Height)
            {
                Number++;
                //Debug.Log("1");
                Invoke("CallNumber", 3f);
            }
        }*/

        if (Number > 1)
        {
            anim.SetBool("jump2", true);
            this.rigit2D.AddForce(transform.up * jumpPower);
        }
        else 
        {
            anim.SetBool("jump2", false);
            

        }


    }

    /*public void onClickAct()
    {
        anim.SetTrigger("start");
        if (flg == true)
        {
            GetComponent<AudioSource>().Play();
            flg = false;
        }

        if (transform.position.y < Height)
        {
            Number++;
            //Debug.Log("1");
            Invoke("CallNumber", 3f);
        }
    }

    

    void CallNumber()
{
    Number = 0;
}*/
}
