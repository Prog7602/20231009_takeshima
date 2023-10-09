using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Transform : MonoBehaviour
{
    float time;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        y = -0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        var v = new Vector3(0.0f, y, 0.0f);
        time += 0.01f;
        if (time >= 25.0f)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(v);

    }
}
