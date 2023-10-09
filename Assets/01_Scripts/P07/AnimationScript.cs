using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
    }
    public int a = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            a++;
        }
        if (a == 1)
        {
            anim.Play();
            Invoke("Load", 1);
        }
    }
    public void Load()
    {
        a = 0;
    }
        
        

}
