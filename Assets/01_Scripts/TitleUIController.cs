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

public class TitleUIController : UIController {
    const string ClassName = "TitleUIController";

    Image dialog_mask;
    RectTransform settei_dialog;
    Image settei_dialog_text_btn;
    Image settei_dialog_narration_btn;
    Image settei_dialog_se_btn;
    const float DisabledButtonOpacity = 0.2f;
    RectTransform howto_dialog;
    RectTransform license_dialog;
    //メモ
    //isTextEnabledを　　以下宣言のis_textに置換するだけでOK
    //置換済みです．
    //bool isTextEnabled;
    bool is_text = text_.is_text_displayed;　//text_.csの変数is_text_displayed 参照させる．
    //bool isNarrationEnabled;
    bool is_audio = audio_.is_text_displayed;
    bool is_se = se_.is_text_displayed;


    override protected void Awake() {
        base.Awake();
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");

        // FIXME
        //this.isTextEnabled = true;
        //this.isNarrationEnabled = true;
        //this.isSeEnabled = true;
    }

    override protected void Start() {
        base.Start();
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");

        this.dialog_mask = transform.FindDeep("dialog_mask").gameObject.GetComponent<Image>();
        this.settei_dialog = transform.FindDeep("settei_dialog").gameObject.GetComponent<RectTransform>();
        this.settei_dialog_text_btn = transform.FindDeep("settei_dialog_text_btn").gameObject.GetComponent<Image>();
        this.settei_dialog_narration_btn = transform.FindDeep("settei_dialog_narration_btn").gameObject.GetComponent<Image>();
        this.settei_dialog_se_btn = transform.FindDeep("settei_dialog_se_btn").gameObject.GetComponent<Image>();
        this.howto_dialog = transform.FindDeep("howto_dialog").gameObject.GetComponent<RectTransform>();
        this.license_dialog = transform.FindDeep("license_dialog").gameObject.GetComponent<RectTransform>();

        //this.settei_dialog_text_btn.SetAlpha(this.isTextEnabled ? 1f : DisabledButtonOpacity);
        this.settei_dialog_text_btn.SetAlpha(is_text ? 1f : DisabledButtonOpacity);
        this.settei_dialog_narration_btn.SetAlpha(is_audio ? 1f : DisabledButtonOpacity);
        this.settei_dialog_se_btn.SetAlpha(is_se ? 1f : DisabledButtonOpacity);
    }

    override protected void Update() {
        base.Update();
    }

    public void Click_hajimeru_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        NextScene();
    }

    public void Click_settei_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        dialog_mask.raycastTarget = true;
        dialog_mask.DOFade(1f, 0.2f);
        settei_dialog.DOAnchorPosY(0, 0.4f).SetEase(Ease.OutBack);
    }

    public void Click_settei_dialog_close_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        settei_dialog.DOAnchorPosY(ScreenSize.y * 1.5f, 0.4f).SetEase(Ease.InBack);
        dialog_mask.DOFade(0f, 0.2f);
        dialog_mask.raycastTarget = false;
    }

    public void Click_settei_dialog_text_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        // FIXME
        //this.isTextEnabled = !this.isTextEnabled;
        this.is_text = !this.is_text;
        this.settei_dialog_text_btn.SetAlpha(this.is_text ? 1f : DisabledButtonOpacity);
    }

     public void Click_settei_dialog_narration_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        // FIXME
        //this.isNarrationEnabled = !this.isNarrationEnabled;
        this.is_audio = !this.is_audio;
        this.settei_dialog_narration_btn.SetAlpha(this.is_audio ? 1f : DisabledButtonOpacity);
    }

    public void Click_settei_dialog_se_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        // FIXME
        //this.isSeEnabled = !this.isSeEnabled;
        this.is_se = !this.is_se;
        this.settei_dialog_se_btn.SetAlpha(this.is_se ? 1f : DisabledButtonOpacity);
    }

    public void Click_settei_dialog_howto_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        settei_dialog.DOAnchorPosY(ScreenSize.y, 0.4f).SetEase(Ease.InBack);
        howto_dialog.DOAnchorPosY(0, 0.4f).SetEase(Ease.OutBack).SetDelay(0.3f);
    }

    public void Click_settei_dialog_credit_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        CreditScene();
    }

    public void Click_settei_dialog_place_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        PlaceScene();
    }

    public void Click_settei_dialog_about_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        AboutScene();
    }

    public void Click_settei_dialog_license_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        settei_dialog.DOAnchorPosY(ScreenSize.y, 0.4f).SetEase(Ease.InBack);
        license_dialog.DOAnchorPosY(0, 0.4f).SetEase(Ease.OutBack).SetDelay(0.3f);
    }

    public void Click_howto_dialog_close_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        howto_dialog.DOAnchorPosY(-ScreenSize.y, 0.4f).SetEase(Ease.InBack);
        settei_dialog.DOAnchorPosY(0, 0.4f).SetEase(Ease.OutBack).SetDelay(0.3f);
    }

    public void Click_license_dialog_close_btn() {
        Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");;

        license_dialog.DOAnchorPosY(-ScreenSize.y, 0.4f).SetEase(Ease.InBack);
        settei_dialog.DOAnchorPosY(0, 0.4f).SetEase(Ease.OutBack).SetDelay(0.3f);
    }
}