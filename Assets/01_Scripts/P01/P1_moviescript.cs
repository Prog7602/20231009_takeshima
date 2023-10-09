using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_moviescript : MonoBehaviour
{
    GameObject ClickO;
    Vector2 ssa;

    // Start is called before the first frame update
    void Start()
    {
        ssa = new Vector2(0.7f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickO = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d && ClickO.name == "hit")
            {
                ClickO = hit2d.transform.gameObject;
                hit2d.transform.localScale = ssa;
            }
            Debug.Log(ClickO);
        }

    }
}
