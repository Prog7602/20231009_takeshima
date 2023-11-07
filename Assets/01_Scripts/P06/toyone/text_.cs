using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_ : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool is_text_displayed = true;//同クラス内で共有使用可能名変数

    public void Start()
    {
        gameObject.SetActive(is_text_displayed);//スクリプトを付けたオブジェクトを　on offする．
    }

    public void toggle ()//呼ばれた実行時にis_text_displayed が真なら偽に　偽なら真にするだけ．
    {
        if(is_text_displayed==true){
            is_text_displayed=false;
        }else if(is_text_displayed==false){
            is_text_displayed=true;
        }
        Debug.Log(is_text_displayed+ "by text_.cs");
    }
    
    public void pxx_text()
    {
        toggle();
        gameObject.SetActive(is_text_displayed);
    }
    
}
