using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hutabascript : MonoBehaviour
{
    public GameObject saplingObj;
    private static bool isQuitting = false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.gameObject.SetActive(false);
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
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    public void OnhutabaAction()
    {
        GetComponent<AudioSource>().Play();
        this.gameObject.SetActive(false);
        saplingObj.SetActive(true);
        saplingObj.GetComponent<BoxCollider2D>().enabled = true;
    }


    /*private void OnDestroy()
    {
        if(!isQuitting)
        {
            Instantiate(saplingObj, this.transform.position, Quaternion.identity);
        }
    }*/
}
