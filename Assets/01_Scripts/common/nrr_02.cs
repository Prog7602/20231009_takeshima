using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nrr_02 : MonoBehaviour
{
    Image sp;
    void Start()
    {
        sp = this.GetComponent<Image>();
        Invoke("appear_tugie",40.0f);   //40秒後に"appear_tugie"関数の処理を開始
    }
    void appear_tugie()
    {
        sp.color = new Color(1,1,1,255);    //ネクストバルーンの色を透明から元に戻す処理
        Debug.Log("40秒経過");
    }
}
