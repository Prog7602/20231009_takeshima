using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Map1()
    {
        Application.OpenURL("https://www.google.co.jp/maps/place/%E7%AB%B9%E5%B3%B6/@34.8110825,137.2297372,17z/data=!4m5!3m4!1s0x6004c6df81383ccb:0xa4530be4319e3f14!8m2!3d34.8110828!4d137.2316874");
    }
    public void Map2()
    {
        Application.OpenURL("https://www.google.co.jp/maps/place/%E5%85%AB%E7%99%BE%E5%AF%8C%E7%A5%9E%E7%A4%BE/@34.8142815,137.2306105,16z/data=!4m5!3m4!1s0x6004c71f65165555:0x400293e366339cb4!8m2!3d34.8105848!4d137.2316344");
    }
    public void Map3()
    {
        Application.OpenURL("https://www.google.co.jp/maps/place/%E8%97%A4%E5%8E%9F%E4%BF%8A%E6%88%90%E5%83%8F/@34.8158724,137.230317,17.81z/data=!4m8!1m2!2m1!1z5L-K5oiQ6IuR!3m4!1s0x6004c721dd8a0e8b:0x8f844df5207d63df!8m2!3d34.8153019!4d137.2333281");
    }
    public void On4()
    {
        Application.OpenURL("https://www.city.gamagori.lg.jp/");
    }
}
