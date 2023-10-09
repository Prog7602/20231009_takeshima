using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stampscropt : MonoBehaviour
{
    public GameObject HutabaObj;
    private static bool isQuitting = false;
    private static bool scene;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "P04")
        {
            this.gameObject.SetActive(true);
            Debug.Log("1");
        }else{
            Debug.Log("2");
            this.gameObject.SetActive(false);
            
        }
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    public void OnstampAction()
    {
        GetComponent<AudioSource>().Play();
        this.gameObject.SetActive(false);
        HutabaObj.SetActive(true);
        HutabaObj.GetComponent<BoxCollider2D>().enabled = true;
    }

    /*private void OnDestroy()
    {
        if(!isQuitting)
        {
            Instantiate(HutabaObj, this.transform.position, Quaternion.identity);
        }
    }*/
}
