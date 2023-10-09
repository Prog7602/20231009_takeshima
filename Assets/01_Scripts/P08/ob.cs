using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class ob : MonoBehaviour
{
    public GameObject[] Train;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;
    private bool isCountdownStart;
    GameObject clickedGameObject;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Train[0], transform.position, transform.rotation);
        //時間間隔を決定する
        interval = 4f;
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            isCountdownStart = true;
        }

        if (isCountdownStart)
        {
            time += Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isCountdownStart = true;


        }

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > interval)
        {
            var number = Random.Range(0, Train.Length);
            Instantiate(Train[number], transform.position, transform.rotation);
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
            isCountdownStart = false;
            
        }
    }

    
        
}
