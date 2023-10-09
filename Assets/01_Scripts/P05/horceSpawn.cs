using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horceSpawn : MonoBehaviour
{

   public Animation anim;
    public Animation anim1;
    public Animation anim2;
    public GameObject horce;            //生成する馬のオブジェクト
    public GameObject spawnPoint;       //生成した馬の最初の位置
    public Vector3[] gotoPositions;     //生成した馬の目的地
    GameObject[] CreatedHorces;         //生成した馬一覧
    private int createNum = 0;          //現在生成した馬の数

    private AudioSource horceRoar;      //生成したときに流すSE
    public AudioClip horceStep;
    void Start() {
        //anim = this.gameObject.GetComponent<Animation>();
        CreatedHorces = new GameObject[gotoPositions.Length];
        horceRoar = GetComponent<AudioSource>();
    }
    void Update()
    {
    
    }
    public void OnClick()
    {
        
        
            if (createNum < CreatedHorces.Length)
            {         
                Vector3 spawnVec = spawnPoint.transform.position;
                GameObject prefab = Instantiate(horce, spawnVec, Quaternion.identity);
                horceRoar.PlayOneShot(horceRoar.clip);
                moveHorce mh = prefab.GetComponent<moveHorce>();
                mh.endPosition = gotoPositions[createNum];
                CreatedHorces[createNum] = prefab;
                createNum++;
                this.anim.Play();
            this.anim1.Play();
            this.anim2.Play();
            this.GetComponent<AudioSource>().PlayOneShot(horceStep);
        }
            else
            {
                foreach (GameObject h in CreatedHorces)
                {
                    moveHorce mh = h.GetComponent<moveHorce>();
                    Vector3 vec = h.transform.position;
                    vec.x = -1400;
                    mh.GoodByeHource(vec);
                this.GetComponent<AudioSource>().PlayOneShot(horceStep);
            }
                createNum = 0;
            }
        
    }

}