using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nrr_09 : MonoBehaviour
{
    Image sp;
    void Start()
    {
        sp = this.GetComponent<Image>();
        Invoke("appear_tugie",23.0f);
    }
    void appear_tugie()
    {
        sp.color = new Color(1,1,1,255);
        Debug.Log("23秒経過");
    }
}
