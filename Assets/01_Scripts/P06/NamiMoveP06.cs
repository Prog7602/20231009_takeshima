using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamiMoveP06 : MonoBehaviour
{
    public new GameObject[] gameObject;
    private Transform transformY;
    private Vector2 posY;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gameObject.Length; i++)
        {
            transformY = gameObject[i].transform;
            posY = transformY.position;
            transformY.position = posY;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin(Time.time);
        for (int i = 0; i < gameObject.Length; i++)
        {
            if (i == 0)
            {
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y += sin/15; /// 150;
                transformY.position = posY;
            }
            else
            if (i == 1)
            {
                sin = Mathf.Sin(Time.time + 1f);
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y += sin/5; /// 50;
                transformY.position = posY;
            }
            else
            if (i == 2)
            {
                sin = Mathf.Sin(Time.time + 0.8f);
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y += sin/5; /// 50;
                transformY.position = posY;
            }
            else
            if (i == 3)
            {
                sin = Mathf.Sin(Time.time);
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y += sin/5; /// 50;
                transformY.position = posY;
            }
        }

    }
}
