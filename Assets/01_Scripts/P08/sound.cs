using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    int i,j;
    private float time;
    private bool isCountdownStart;
    private int counter;
    private float interval;

    GameObject clickedGameObject;
    //public DeleteObject target;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        j = 0;
        time = 0f;
        counter = 0;
        interval = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            i++;
            isCountdownStart = true;
            if (j == 0)
            {
                j = 1;
                
                Invoke("Number", 4f);
            }
            
            Debug.Log(i);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hit2d)
            {
                
                clickedGameObject = hit2d.transform.gameObject;
                if (Input.GetMouseButton(0)&&i>1)
                {
                    
                    if (hit2d.collider.CompareTag("Player"))
                    {
                        
                        GetComponent<AudioSource>().Play();

                    }

                }
            }
        }

        if (isCountdownStart)
        {
            time += Time.deltaTime;
        }

        //Œo‰ßŽžŠÔ‚ª¶¬ŽžŠÔ‚É‚È‚Á‚½‚Æ‚«(¶¬ŽžŠÔ‚æ‚è‘å‚«‚­‚È‚Á‚½‚Æ‚«)
        if (time > interval)
        {
            counter = 0;
            time = 0f;
            isCountdownStart = false;
            //Debug.Log("1");
        }

    }

    void Number()
    {
        i = 0;
        j = 0;
    }
}


    
