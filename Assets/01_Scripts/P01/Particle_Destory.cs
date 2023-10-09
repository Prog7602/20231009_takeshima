using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Destory : MonoBehaviour
{
    float yziku;
    float secomd = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        secomd = -0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        yziku = this.transform.position.y;
        var v = new Vector3(0.0f, secomd, 0.0f);
        transform.Translate(v);
        if (yziku<= -100.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
