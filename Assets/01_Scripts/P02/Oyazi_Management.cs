using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyazi_Management : MonoBehaviour
{
    public Vector2 _arm_position;
    private Vector2 senterPos;
    private float armmovetime = 1.0f;
    private float MoveTimer;
    public float arm = 0;
    private bool isCountdownStart;
    // Start is called before the first frame update
    void Start()
    {
        isCountdownStart = false;
        _arm_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arm, 0f, 0f);

        if (isCountdownStart)
        {
            MoveTimer += Time.deltaTime;
        }

        if (MoveTimer < armmovetime / 2&& MoveTimer>0)
        {
            this.arm = -1.5f;
        }
        else if (MoveTimer >= armmovetime / 2&& MoveTimer < armmovetime)
        {
            this.arm = 1.5f;
        }
        else if (MoveTimer>= armmovetime)
        {
            this.arm = 0f;
            MoveTimer = 0;
            isCountdownStart = false;
            transform.position = _arm_position;
        }
    }
        

   public void movearm()
       {
        isCountdownStart = true;

        
        }
    
}
