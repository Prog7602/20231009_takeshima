using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    //初期化して透明度を100％にする．
    //01以外に適応することで01を初めから表示
    
    SpriteRenderer spriteRenderer;
    void Start()
    {   //透明度を100%にする
        //BoxCollider2Dを持つ場合には無効にする．
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.color = new Color(1, 1, 1,0);
        if(this.GetComponent<BoxCollider2D>() != null)
        { 
        GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    // Update is called once per frame
  
}
