using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincontroller : MonoBehaviour
{
    public float time;
    public GameObject gameobject;
    public GameObject ski1;
    private bool isCountdownStart;

    GameObject clickedGameObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isCountdownStart==true)
        {
            time += Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isCountdownStart = true;

            clickedGameObject = null;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hit2d)
            {
                
                clickedGameObject = hit2d.transform.gameObject;
                if (Input.GetMouseButton(0))
                {
                    Debug.Log("1");
                    if (clickedGameObject.name == "player(Clone)" )
                    {
                        Debug.Log("2");
                        ski1.GetComponent<player>().Skijump(); 
                        time = 0;
                        isCountdownStart = false;
                    }
                  
                }
            }
        }

        if(time >= 100f)
        {
            Debug.Log("7");
            ski1.GetComponent<player>().Skigoro();
            time = 0;
        }
    }
}