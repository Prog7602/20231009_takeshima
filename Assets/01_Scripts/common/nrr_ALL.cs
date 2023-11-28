using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nrr_ALL : MonoBehaviour
{
    Image sp;

    public float timer; //インスペクターから朗読音声ファイルの出力時間を入力

    void Start()
    {
        sp = this.GetComponent<Image>();
        timer++; //１秒足すことで朗読が終わった後、丁度いいタイミングでネクストバルーンが出るようにしている。
        Invoke("appear_tugie", timer); //一定秒数経過後、appear_tugieを読み込む。
    }

    void appear_tugie()
    {
        sp.color = new Color(1, 1, 1, 255); //ネクストバルーンを透明状態から非透明状態にしている。
        Debug.Log(timer + "秒経過"); //コンソールに経過秒数を表示
    }
}
