using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nrr_10 : MonoBehaviour
{
    Image sp;

    public float timer;

    void Start()
    {
        sp = this.GetComponent<Image>();
        Invoke("appear_tugie", timer);
    }

    void appear_tugie()
    {
        sp.color = new Color(1, 1, 1, 255);
        Debug.Log(timer + "秒経過");
    }
}
