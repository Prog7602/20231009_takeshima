using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nrr_04 : MonoBehaviour
{
    Image sp;
    void Start()
    {
        sp = this.GetComponent<Image>();
        Invoke("appear_tugie",43.0f);
    }
    void appear_tugie()
    {
        sp.color = new Color(1,1,1,255);
        Debug.Log("48秒経過");
    }
}
