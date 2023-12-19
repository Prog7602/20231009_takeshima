using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMove : MonoBehaviour
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
            if (i % 3 == 0)
            {
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y += sin / 8;
                transformY.position = posY;
            }
            else
            if (i % 3 == 1)
            {
                sin = Mathf.Sin(Time.time + i);
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y -= sin / 6;
                transformY.position = posY;
            }
            else
            if (i % 3 == 2)
            {
                sin = Mathf.Sin(Time.time + i);
                transformY = gameObject[i].transform;
                posY = transformY.position;
                posY.y += sin / 5;
                transformY.position = posY;
            }
        }

    }
}