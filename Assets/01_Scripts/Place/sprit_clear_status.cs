using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprit_clear_status : MonoBehaviour
{   //主な目的　SpritRendererの持つ透明度を操作する
    SpriteRenderer spriteRenderer;

    public void ChangeTransparency () 
    { 
    //透明度を0％にして画像を表示する
    //BoxCollinder2Dを持っているときに有効にする．
    //これにより小窓写真(01sとか）の判定をつける．
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.color = new Color(1,1,1,255);
        if(this.GetComponent<BoxCollider2D>() != null){ 
        GetComponent<BoxCollider2D>().enabled = true;
        }

    }
      public void clear()
    {   //透明度を100％にして画像を非表示にする．
        //BoxCollinder2Dを持つ場合に無効にする
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.color = new Color(1, 1, 1,0);
        if(this.GetComponent<BoxCollider2D>() != null){ 
        GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    
}
