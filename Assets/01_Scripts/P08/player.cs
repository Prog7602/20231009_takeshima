using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rigit2D;
    private float jumpPower = 7000.0f;
    public float Height = 397f;
    private float position;
    private Animator anim = null;
    private int Number = 0;
    private bool flg = true;
    private bool jump = true;
    private bool pyon = false;
    private bool zusa = false;

    public int i, j;
    
    GameObject clickedGameObject;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        this.rigit2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        j = 0;
        i = 0;

    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position.y;

        if (Input.GetMouseButtonDown(0))
        {
            i++;
            if (i == 1 )
            {
                
                flg = false;
                GetComponent<AudioSource>().Play();
            }

            clickedGameObject = null;
            if (j == 0)
            {
                j = 1;
                anim.SetTrigger("start");
                Invoke("CallNumber", 4f);
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hit2d)
            {

                clickedGameObject = hit2d.transform.gameObject;
                if (Input.GetMouseButton(0)&&i>1)
                {
                    
                    if (hit2d.collider.CompareTag("Player"))
                    {
                        
                        GetComponent<player>().Skijump();
                        
                    }

                }
            }
            
        }

        

        if(pyon==true)
        {
            
            anim.SetBool("jump", true);
            /*anim.SetBool("jump2", true);
            anim.SetBool("jump3", true);
            anim.SetBool("jump4", true);
            anim.SetBool("jump5", true);*/
            this.rigit2D.AddForce(transform.up * jumpPower);
        }

        if(zusa==true)
        {
            anim.SetBool("jump", false);
        }

        
    }




    

    void CallNumber()
    {
        i = 0;
    }

    public void Skijump()
    {
        
        pyon = true;
    }

    public void Skigoro()
    {
        zusa = true;
        
    }
}


    

