using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitoMove : MonoBehaviour
{
    public Transform human;
    public float xpos = -90f;
    public float ypos = 441f;
    private float distance;
    private float presentPos;
    public float speed = 1.0f;
    public float xPosEnd = 0;
    public float yPosEnd = 0;
    private Vector3 endPos;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        endPos = new Vector3(xPosEnd, yPosEnd, 0);
        startPos = new Vector3(xpos, ypos, 0);
        human.position = new Vector3(xpos, ypos, 0);
        Debug.Log(human.position);
        distance = Vector3.Distance(startPos, endPos);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        human.position = Vector3.MoveTowards(human.position, endPos, speed);
    }
}