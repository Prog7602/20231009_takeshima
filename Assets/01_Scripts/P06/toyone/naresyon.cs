using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class naresyon : MonoBehaviour
{   
    // Start is called before the first frame update
    Image sp;
    void Start()
    {
        sp = this.GetComponent<Image>();
        Invoke("appear_tugie",37.0f);
    }
    void appear_tugie()
    {
        sp.color = new Color(1,1,1,255);
        Debug.Log("37秒経過");
    }
    
}
