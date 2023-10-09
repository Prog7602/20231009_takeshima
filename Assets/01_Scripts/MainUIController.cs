using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using KoganeUnityLib;
using Karakuri;

public class MainUIController : UIController {
    const string ClassName = "MainUIController";

    Image text_win;
    Image home_btn;
    Image text_btn;
    Image next_btn;
    Image home2_btn;
    Image dialog_mask;
    RectTransform alert_dialog;
    bool isTextEnabled;
    bool isNarrationEnabled;
    bool isSeEnabled;
   

    void Awake() {
        base.Awake();
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");

        // FIXME
        this.isTextEnabled = false;
        this.isNarrationEnabled = true;
        this.isSeEnabled = true;
    }

    void Start() {
        base.Start();
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");

        this.text_win = transform.FindDeep("text_win").gameObject.GetComponent<Image>();
        this.home_btn = transform.FindDeep("home_btn").gameObject.GetComponent<Image>();
        this.text_btn = transform.FindDeep("text_btn").gameObject.GetComponent<Image>();
        this.next_btn = transform.FindDeep("next_btn").gameObject.GetComponent<Image>();
        this.home2_btn = transform.FindDeep("home2_btn").gameObject.GetComponent<Image>();
        if (transform.FindDeep("dialog_mask"))
        {
            this.dialog_mask = transform.FindDeep("dialog_mask").gameObject.GetComponent<Image>();
        }
        this.alert_dialog = transform.FindDeep("alert_dialog").gameObject.GetComponent<RectTransform>();

        if (IsMainScene()) {
            if (isTextEnabled) {
                //this.text_win.SetAlpha(1);
            } else {
                //this.text_win.SetAlpha(0);
            }
        } else {
            //this.text_win.SetAlpha(0);
            //this.text_btn.SetAlpha(0);
            this.text_btn.raycastTarget = false;
        }
        if (!IsLastScene()) {
            this.next_btn.SetAlpha(1);
            this.next_btn.raycastTarget = true;
            this.home2_btn.SetAlpha(0);
            this.home2_btn.raycastTarget = false;
        } else {
            this.home_btn.SetAlpha(0);
            this.home_btn.raycastTarget = false;
            this.next_btn.SetAlpha(0);
            this.next_btn.raycastTarget = false;
            this.home2_btn.SetAlpha(1);
            this.home2_btn.raycastTarget = true;
        }
    }

    void Update() {
        base.Update();
    }

    public void Click_home_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
        
        /*if(GameObject.Find ("dialog_mask").GetComponent<Image>()){
            Debug.Log("Find dialog_mask");
        }
        }else{
            Debug.Log("Not Find dialog_mask");
        }//dialog_maskのImage コンポーネントは存在する．
        */
        
             //dialog_mask.raycastTarget = true;
        
        //DOTween.Clear(true);
         dialog_mask.DOFade(1f, 0.2f);
        alert_dialog.DOAnchorPosY(0, 0.4f).SetEase(Ease.OutBack);//問題点ここ
        
        
        //dialog_maskのImage コンポーネントは存在する．
        
       

        
    }

    public void Click_text_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        isTextEnabled = !isTextEnabled;
        text_win.DOFade(isTextEnabled ? 1 : 0, 0.2f);
    }

    public void Click_prev_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
        DOTween.Clear(true);
        PrevScene();
    }

    public void Click_next_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
        DOTween.Clear(true);
        NextScene();
    }

    public void Click_home2_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
        DOTween.Clear(true);
        TitleScene();
    }

    public void Click_alert_dialog_yes_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
        DOTween.Clear(true);
        TitleScene();
    }

    public void Click_alert_dialog_no_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;
        
        alert_dialog.DOAnchorPosY(ScreenSize.y, 0.4f).SetEase(Ease.InBack);
        dialog_mask.DOFade(0f, 0.2f);
        dialog_mask.raycastTarget = false;
    }
}