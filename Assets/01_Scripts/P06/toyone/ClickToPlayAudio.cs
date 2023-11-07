using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlayAudio : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    private int audioTypeFlag=0; 
    
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    
    void Update()
    {   //再生する音声の種類を決定．
        if(Input.GetMouseButtonUp(0)&&audioTypeFlag==0){
            //Input.GetMouseButtonDownの引数0で左クリックor画面タップでtureを返す
            audioSource.PlayOneShot(sound1);
            audioTypeFlag++;
        }else if(Input.GetMouseButtonUp(0)&&audioTypeFlag==1){
            audioSource.PlayOneShot(sound2);
            audioTypeFlag++;
        }else if(Input.GetMouseButtonUp(0)&&audioTypeFlag==2){
            audioSource.PlayOneShot(sound2);
            audioTypeFlag++;
        }else if(Input.GetMouseButtonUp(0)&&audioTypeFlag==3){
            audioSource.PlayOneShot(sound3);
            audioTypeFlag++;
        }else if(Input.GetMouseButtonUp(0)&&audioTypeFlag==4){
            audioSource.PlayOneShot(sound4);
            audioTypeFlag=0;
        }
    }
}
