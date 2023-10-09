using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{   //外部サイトを開くためのメソッドを持つ
      public void about()
    {   //豊根村のgoogleMap検索結果
        Application.OpenURL("https://goo.gl/maps/RsWK21yMgSb19n8k8");//""の中には開きたいWebページのURLを入力します
    }
     public void chausu()
     {  //茶臼山
         Application.OpenURL("https://goo.gl/maps/QrBCuMETeg5S22Zk6");
     }
     public void jinjya()
    {   //川字連神社
        Application.OpenURL("https://goo.gl/maps/csNXfLBdP7A9AcM28");
    }
     public void shinntoyonedamu()
     {  //新豊根ダムの操縦室
         Application.OpenURL("https://goo.gl/maps/QU2XGqeceWAX1Vni9");
     }

}
