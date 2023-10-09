using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P04Manager : MonoBehaviour
{
    public int i, j, k,l;
    public string TreeTag = "Tree";
    public string stampTag = "stamp";
    public string SaplingTag = "sapling";
    public string HutabaTag = "hutaba";
    public GameObject baseTree;
    public GameObject baseStump;
    public GameObject baseSapling;
    public GameObject baseHutaba;
    public GameObject[] trees;
    public GameObject[] stumps;
    public GameObject[] Hutaba;
    public GameObject[] saplings;
    public Vector2[] location;
    public AudioClip sound1;
    public AudioClip sound2;

    private float ts_difference_y = 375f;//375  木と切り株のスプライトの差　ずれると断面が見える
    // Start is called before the first frame update
    AudioSource audioSource;

    void Start()
    {
        i = 0;
        j = 0;
        k = 0;
        l = 24;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
            if (hit2d)
            {
                if (hit2d.transform.gameObject.CompareTag(TreeTag) && l >= 24)
                {
                    hit2d.transform.gameObject.GetComponent<Rotation>().OnUserAction();
                    i++;
                }
                else if(hit2d.transform.gameObject.CompareTag(stampTag) && i>=6 && l>=24)
                {
                    hit2d.transform.gameObject.GetComponent<Stampscropt>().OnstampAction();
                    audioSource.PlayOneShot(sound1);
                    j++;
                }
                else if(hit2d.transform.gameObject.CompareTag(HutabaTag)&& j>=6)
                {
                    hit2d.transform.gameObject.GetComponent<Hutabascript>().OnhutabaAction();
                    audioSource.PlayOneShot(sound2);
                    k++;
                    l = 0;
                }
                else if(hit2d.transform.gameObject.CompareTag(SaplingTag)&& k>=6)
                {
                    hit2d.transform.gameObject.GetComponent<saplingscript>().OnsaplingAction();

                    audioSource.PlayOneShot(sound2);
                    l++;
                    if (l >= 24)
                    {
                        i = 0;
                        j = 0;
                        k = 0;
                    }
                }
            }
            /*else
            {
                //木が残っているとき
                if(trees[0] != null) {
                    foreach (GameObject Tree in trees)
                    {

                        if (Tree.GetComponent<Rotation>().rotation_speed == 0.0f)
                        {
                            return;
                        }
                        //Debug.Log("1");
                    }
                    
                }
                //切り株の削除 双葉を植える
                else if(stumps[0] != null)
                {
                    foreach (GameObject stump in stumps)
                    { 

                        audioSource.PlayOneShot(sound1);
                    }
                }
                //苗木を植える
                else if(saplings[0] == null)
                {
                    

                    for (int i = 0;i < location.Length; i++)
                    {
                        Vector3 vector3 = location[i];
                        saplings[i] = GameObject.Instantiate(baseSapling, vector3, Quaternion.identity);
                    }
                    audioSource.PlayOneShot(sound2);
                }
                //木が育つ
                else 
                {
                    foreach (GameObject sapling in saplings) Destroy(sapling);
                    for(int i = 0;i < location.Length; i++)
                    {
                        Vector3 vector3 = location[i];
                        stumps[i] = GameObject.Instantiate(baseStump, vector3, Quaternion.identity);
                        vector3.y += ts_difference_y;
                        trees[i]  = GameObject.Instantiate(baseTree, vector3, Quaternion.identity);
                    }
                    audioSource.PlayOneShot(sound2);
                }
            }*/
        }
    }
}
