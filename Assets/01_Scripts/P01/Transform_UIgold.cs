using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_UIgold : MonoBehaviour
{

    public float objy = -0.25f;
    public int limit = -140;

    Vector3 objlate;

    // Start is called before the first frame update
    void Start()
    {
        objlate = new Vector3(0.0f, objy, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.position.y >= limit)
        {
            //下がる処理
            this.transform.Translate(objlate);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
