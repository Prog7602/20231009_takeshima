using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class yukari_photo : MonoBehaviour
{
    public float Limit1;
    public float Limit2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void On1()
    {
        //this.transform.DOMove(new Vector3(90.0f, 270.0f, 0f), 1f);
        this.transform.DOLocalMove(new Vector3(0.0f, 0.0f, 0f), 1f);
    }
    public void On2()
    {
        this.transform.DOLocalMove(new Vector3(Limit1, 0.0f, 0f), 1f);
    }
    public void On3()
    {
        this.transform.DOLocalMove(new Vector3(Limit2, 0.0f, 0f), 1f);
    }
}
