using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using KoganeUnityLib;

public class AboutController : MonoBehaviour {
    const string ClassName = "AboutController";

    RectTransform website_btn;

    void Awake() {
        Debug.Log("enter " + MethodBase.GetCurrentMethod().Name + "()");
    }

    void Start() {
        Debug.Log("enter " + MethodBase.GetCurrentMethod().Name + "()");

        this.website_btn = transform.FindDeep("website_btn").gameObject.GetComponent<RectTransform>();
        float fromY = website_btn.position.y;
        float toY = fromY + 10f;
        Sequence seq = DOTween.Sequence()
            .Append(website_btn.DOMoveY(toY, 1f))
            .Append(website_btn.DOMoveY(fromY, 1f))
            .SetLoops(-1);
    }

    void Update() {

    }

    public void Click_website_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
    }
}