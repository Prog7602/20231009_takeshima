using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_s : MonoBehaviour
{

    GameObject Accse1,Accse2,Accse3,Accse4;

    public string sptag = "wall";

    // Start is called before the first frame update
    void Start()
    {
        Accse1 = GameObject.Find("kumo_right_1");
        Accse2 = GameObject.Find("kumo_right_2");
        Accse3 = GameObject.Find("kumo_left");
        Accse4 = GameObject.Find("Main Camera");
        //Accse1 = GameObject.Find("kumo_right_1");
    }

    // Update is called once per frame
    void Update()
    {
        int i;
        if (Input.GetMouseButtonDown(0))
        { 
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
                if (hit)
                {
                    //clickGO = hit.collider.gameObject;
                    //kumo_move a = GetComponent<kumo_move>();
                    if (hit.collider.gameObject.CompareTag(sptag))
                    {
                        //a.Move();

                        Debug.Log("tetti");

                        for (i = 0; i < 100; i++)
                        {
                            Accse1.GetComponent<kumo_move>().Move();
                            Accse2.GetComponent<kumo_move>().Move();
                            Accse3.GetComponent<kumo_move2>().Move();
                            Accse4.GetComponent<camera_zome>().Move();
                            //Accse1.GetComponent<kumo_mpve2>();
                        }

                    }
                }
            }
        }
    }

}


