using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alpha : MonoBehaviour
{
    public float changeSpeed = 0.01f;
    public GameObject hito;
    public SpriteRenderer image;
    private Color imageColor;

    // Start is called before the first frame update
    void Start()
    {
        image = hito.GetComponent<SpriteRenderer>();
        imageColor = image.color;
        imageColor.a = 0;
        image.color = imageColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (imageColor.a < 1f)
        {
            imageColor = image.color;
            imageColor.a += changeSpeed;
            image.color = imageColor;
        }
    }
}