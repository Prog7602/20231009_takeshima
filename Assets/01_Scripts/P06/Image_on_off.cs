using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Image_on_off : MonoBehaviour
{
    public void Start()
    {//画像の非表示
        //this.GetComponent<Image>().enabled =false;
    }

    public void Change_Image_component_toggle()
    {
        if(GetComponent<Image>().enabled == true)
        {   //画像の非表示
             this.GetComponent<Image>().enabled = false;
        }else
        {   //画像の表示
            this.GetComponent<Image>().enabled = true;
        }
    }
}
