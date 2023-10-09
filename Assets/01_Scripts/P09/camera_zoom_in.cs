using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_zoom_in : MonoBehaviour
{
    Transform tf;
    Camera cam;
    private int MW;
    // Start is called before the first frame update
    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>();
        cam = this.gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MW == 1)
        {
            cam.orthographicSize = cam.orthographicSize + 0.15f;
        }
        if (cam.orthographicSize >= 725.0f)
        {
            MW = 0;
        }
    }
    public void Move()
    {
        Debug.Log("acsses on3");
        MW = 1;
    }
}
