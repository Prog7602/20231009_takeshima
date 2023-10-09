using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nrr_08 : MonoBehaviour
{
    Image sp;
    void Start()
    {
        sp = this.GetComponent<Image>();
        Invoke("appear_tugie",39.0f);   //39秒処理を待つ
    }
    void appear_tugie()
    {
        sp.color = new Color(1,1,1,255);    //ネクストバルーンの透明度を元に戻す処理
        Debug.Log("39秒経過");
    }
}
