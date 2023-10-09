using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnclickScript03 : MonoBehaviour
{
    public GameObject gameobject;
    public SpriteRenderer spriteRenderer;
    Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameobject.GetComponent<Animation>();
    }
    public int a = 8;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            a++;
        }
        if ((a == 0 || a == 9) && Input.GetMouseButtonDown(0))
        {
            anim.Play("skeerAnimation3");
        }
        if (a == 1)
        {

        }
        if (a == 2&& Input.GetMouseButtonDown(0))
        {
            anim.Play("skeetAnimation");

        }
        if (a == 3)
        {

        }
        if (a == 4&&Input.GetMouseButtonDown(0))
        {
            anim.Play("skeetAnimation2");
        }
        if (a == 5)
        {
            a = 3;
        }
        if (a == 9)
        {
            a = 0;
        }
    }
}
