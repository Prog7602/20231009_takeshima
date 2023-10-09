using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_zome : MonoBehaviour
{
    private GameObject cammee = null;
    private Camera cam;
    private float zoom;
    private float view;
    private int MW;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<camera_zome>().enabled = true;
        cammee = GameObject.Find("Main Camera");
        cam = GetComponent<Camera>();
        view = cam.orthographicSize;
        cam.orthographicSize = 735f;
    }




    // Update is called once per frame
    void Update()
    {
        if(MW == 1) 
        {
            Invoke("stopMethod", 8.0f);
            cam.orthographicSize = view + zoom;

            // 最小値と最大値を決める（自由に変更可能）
            if(cam.orthographicSize < 200f)
            {
                cam.orthographicSize = 200;
                
               
            }

                // 「自分の主観カメラ」を基準に数値を決めてください。
                if (cam.fieldOfView > 500f)
            {
                cam.orthographicSize = 500f;
            }

            zoom -= 1.5f; 
        }
        
    }

    // Update is called once per frame
    public void Move()
    {
        Debug.Log("acsses on3");
        MW = 1;
    }
    public void stopMethod()
    {
        Debug.Log("ok");
        GetComponent<camera_zome>().enabled = false;
    }
}
