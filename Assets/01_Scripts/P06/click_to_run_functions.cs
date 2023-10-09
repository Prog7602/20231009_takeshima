using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_to_run_functions : MonoBehaviour
{
    public GameObject gameobject;
    public AudioClip sound1;
    Animation anim;
    AudioSource audioSource;
    public void Start(){
        anim = this.gameobject.GetComponent<Animation>();
        audioSource = this.GetComponent<AudioSource>();

    }
   //play_obtain_ConponentAnimetionくらいが妥当だが30以上のオブジェクトにOnClic()で渡しているため変更は簡単では無かった
    public void OnClick(){
        Debug.Log("on click!");
        anim.Play();
    }
    public void play_obtain_ComponentAudio(){
        audioSource.PlayOneShot(sound1);
    }


}
