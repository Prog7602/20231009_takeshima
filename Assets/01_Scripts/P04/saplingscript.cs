using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saplingscript : MonoBehaviour
{
    public int i = 0;
    public GameObject stampObj;
    public GameObject treeObj;
    private static bool isQuitting = false;
    private Animator anim = null;
    public BoxCollider2D tree; 
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        this.gameObject.SetActive(false);
        // transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 50f, this.transform.position.z); 
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "P04")
        {
            this.gameObject.SetActive(true);
        }else{
            this.gameObject.SetActive(false);
        }
        audioSource = GetComponent<AudioSource>();
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    public void OnsaplingAction()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<BoxCollider2D>().enabled = false;
        Invoke("delay",1f);
        anim.SetTrigger("grow1");
        i++;
        if (i >= 4)
        {
        this.gameObject.SetActive(false);
        stampObj.SetActive(true);
        treeObj.transform.position= new Vector3(treeObj.transform.position.x,-300f,-54f);
        GetComponent<BoxCollider2D>().enabled = false;
        tree.enabled = true;
        i=0;
        }
    }

    public void delay()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }

    /*private void OnDestroy()
    {
        if(!isQuitting)
        {
            Instantiate(stampObj, transform.position, Quaternion.identity);
            Instantiate(treeObj, transform.position, Quaternion.identity);
        }
    }*/
}
