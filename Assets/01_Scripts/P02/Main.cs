using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public AudioClip _sound1;
    public AudioClip _sound2;
    public AudioClip _sound3;
    public AudioClip _sound4;

    public GameObject _bowl_effect;
    public GameObject _bowl;
    public GameObject _bowl_respown;
    public GameObject Oyajiarm;
    public GameObject axis;
    public GameObject machineeffect;
    public GameObject shelf1;
    public GameObject shelf2;
    public GameObject shelf3;
    public GameObject shelf4;
    public GameObject shelf5;
    public GameObject shelf6;
    public GameObject shelf7;
    public GameObject shaving1;
    public GameObject shaving2;
    public GameObject strings;
    public Animation anim;
    GameObject gameobject;


    public Vector2[] _shelf_point;
    //public Quaternion _rotate;

    public Image Bowl;
    public Sprite same;

    private int _bowl_num = 0;
    private float _timer;
    private float _speed = 2.0f;
    private int _count;

    GameObject clickedGameObject;
    AudioSource audioSource;

    void Start()
    {
        gameobject = GameObject.Find("Bowl");
        audioSource = GetComponent<AudioSource>();
        _bowl_effect.SetActive(false);
        machineeffect.SetActive(false);
        shaving1.SetActive(false);
        shaving2.SetActive(false);
        shelf1.SetActive(false);
        shelf2.SetActive(false);
        shelf3.SetActive(false);
        shelf4.SetActive(false);
        shelf5.SetActive(false);
        shelf6.SetActive(false);
        shelf7.SetActive(false);
        //strings.SetActive(true);
        _timer = 1.0f;
        _count = 0;
        //var quaternion = Quaternion.Euler(0.0f, 0.0f, -270f);
        //_rotate = Quaternion.Inverse(quaternion);

    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= 1.0f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                clickedGameObject = null;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
                _timer = 0.0f;

                if (hit2d)
                {
                    clickedGameObject = hit2d.transform.gameObject;
                    if(_bowl_num < 7)
                    {

                        if (Input.GetMouseButton(0))
                        {
                            audioSource.PlayOneShot(_sound1);
                            audioSource.PlayOneShot(_sound2);
                            axis.GetComponent<deshi>().deshiarm();
                            machineeffectTrue();
                            OyajiarmMove();
                            BowlEffectTrue();
                            anim.Play();
                        }
                        /*else if (_count < 3)
                        {
                            if (clickedGameObject.name == "Oyazi")
                            {
                                audioSource.PlayOneShot(_sound1);
                                OyajiarmMove();
                            }
                            */
                            /*else if (clickedGameObject.name == "Bowl")
                            {
                                audioSource.PlayOneShot(_sound3);
                                BowlEffectTrue();
                            }
                        }*/
                    }
                    else
                    {
                        _bowl_num = 0;
                        shelf1.SetActive(false);
                        shelf2.SetActive(false);
                        shelf3.SetActive(false);
                        shelf4.SetActive(false);
                        shelf5.SetActive(false);
                        shelf6.SetActive(false);
                        shelf7.SetActive(false);
                    }
                }
            }
        }
    }

    public void machineeffectTrue()
    {
        machineeffect.SetActive(true);
        //strings.SetActive(false);
        shaving1.SetActive(true);
        shaving2.SetActive(true);
        Invoke("machineefectfalse", 1);
        Invoke("shavingeffect", 1);
    }

    public void machineefectfalse()
    {
        machineeffect.SetActive(false);
        strings.SetActive(true);
    }

    public void BowlEffectTrue()
    {
        _count++;

        if (_count < 3)
        {
            _bowl_effect.SetActive(true);
            Invoke("BowlEffectFalse", 1);
        }
        else
        {
            gameobject.GetComponent<BowlMove>().Bowl_rotation();
            BowlRespown();
            _count = 0;
        }

        //Debug.Log(_count);
    }

    void BowlEffectFalse()
    {
        _bowl_effect.SetActive(false);
    }

    public void BowlRespown()
    {
        BowlMove _mb = _bowl.GetComponent<BowlMove>();
        _mb._target_position = _shelf_point[_bowl_num];
        //_mb._rotation = _rotate;
        _bowl_num += 1;
        audioSource.PlayOneShot(_sound4);
        Invoke("change", 2f);
        
    }

    public void OyajiarmMove()
    {
        Oyajiarm.GetComponent<Oyazi_Management>().movearm();
        /*shaving1.SetActive(true);
        shaving2.SetActive(true);
        Invoke("shavingeffect", 1);*/

    }

    public void shavingeffect()
    {
        shaving1.SetActive(false);
        shaving2.SetActive(false);
    }

    public void change()
    {
        BowlMove _mb = _bowl.GetComponent<BowlMove>();
        _mb._target_position = _shelf_point[7];
        if (_bowl_num == 1)
        {
            shelf1.SetActive(true);
        }
        else if (_bowl_num == 2)
        {
            shelf2.SetActive(true);
        }
        else if (_bowl_num == 3)
        {
            shelf3.SetActive(true);
        }
        else if (_bowl_num == 4) 
        {
            shelf4.SetActive(true);
        }
        else if (_bowl_num == 5) 
        {
            shelf5.SetActive(true);
        }
        else if (_bowl_num == 6) 
        {
            shelf6.SetActive(true);
        }
        else if (_bowl_num == 7)
        {
            shelf7.SetActive(true);
        }
    }
}

