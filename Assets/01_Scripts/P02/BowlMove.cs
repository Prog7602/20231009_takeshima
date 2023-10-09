using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlMove : MonoBehaviour
{
    public Vector2 _target_position;
    public float _speed;
    //public Quaternion _rotation;
    private Animator anim = null;
    public GameObject[] respownproject;

    // Start is called before the first frame update
    void Start()
    {
        _target_position = transform.position;
        //_rotation = transform.rotation;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float _step = _speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _target_position, _step*Time.deltaTime);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, _rotation, _step * Time.deltaTime );
    }

    public void Bowl_rotation()
    {
        anim.SetBool("bowlrotation",true);
        Invoke("DelayMethod", 2f);
    }

    public void DelayMethod()
    {
        transform.position = new Vector3(-25f, -220, -10f);
        anim.SetBool("bowlrotation", false);
    }
}
