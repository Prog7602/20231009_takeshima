using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chage_clear_status : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private bool Is_Transparency_zero = false;
    public void ChangeTransparency()
    {
        if(Is_Transparency_zero)
        {
            UpTransparency();
            Is_Transparency_zero = false;
        }else
        {
            DownTransparency();
            Is_Transparency_zero = true;
        }
    }

    private void DownTransparency () 
    { 
    //透明度を0％にして画像を表示する
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.color = new Color(1,1,1,255);
    }

    
    private void UpTransparency ()
    {   //透明度を100％にして画像を非表示にする．
        //BoxCollinder2Dを持つ場合に無効にする
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.color = new Color(1, 1, 1,0);
    }
}
