using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Particle_Instase_Script : MonoBehaviour
{
    int ls;
    public int limit_ls;

    //public List<GameObject> ptc;
    public GameObject parent;
    public GameObject gold; 
    // Start is called before the first frame update
    void Start()
    {
        ls = 0;
        //Instantiate(gold, new Vector3(-150, -80, 0), Quaternion.identity,parent.transform);
        Instantiate(gold, parent.transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ls < limit_ls)
        {
            ls++;
        }
        else
        {
            ls = 0;
            Instantiate(gold, parent.transform);
        }
       

    }
}
