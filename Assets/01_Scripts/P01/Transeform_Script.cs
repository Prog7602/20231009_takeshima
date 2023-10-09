using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transeform_Script : MonoBehaviour
{
    public float speed;
    public int limit;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 tmplocal = this.transform.localPosition;
        if (tmplocal.x > limit)
        {
            var v1 = new Vector3(speed, 0f, 0f);
            transform.Translate(v1);
        }
        /*else
        {
            var v2 = new Vector3(0f, 0f, 0f);
            transform.Translate(v2);
        }*/
    }
}
