using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using KoganeUnityLib;

namespace Karakuri {
    public class UIController : MonoBehaviour {
        const string ClassName = "UIController";
        readonly protected Vector2 ScreenSize = new Vector2(2048, 1536);

        List<string> sceneNames = new List<string>();

        virtual protected void Awake() {
            Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");

            const string scenesDirPath = "Assets/00_Scenes/";
            string sceneName = "Title";
            int index = SceneUtility.GetBuildIndexByScenePath(scenesDirPath + sceneName + ".unity");
            Assert.IsTrue(index >= 0);
            sceneNames.Add(sceneName);
            for (int i = 1;; i++) {
                sceneName = $"P{i:00}";
                index = SceneUtility.GetBuildIndexByScenePath(scenesDirPath + sceneName + ".unity");
                if (index < 0) break;
                sceneNames.Add(sceneName);
            }
            string[] arr = { "Fin", "Credit", "Place", "About", "About1" };
            arr.ForEach(sn => {
                index = SceneUtility.GetBuildIndexByScenePath(scenesDirPath + sn + ".unity");
                Assert.IsTrue(index >= 0);//シーンをビルドしてないとバグる
                sceneNames.Add(sn);
            });
            sceneNames.ForEach(sn => Debug.Log(sn));
        }

        virtual protected void Start() {
            Debug.Log("enter " + ClassName + "." + MethodBase.GetCurrentMethod().Name + "()");
        }

        virtual protected void Update() {
        }

        string GetActiveSceneName() {
            return SceneManager.GetActiveScene().name;
        }

        int GetSceneIndexByName(string sceneName) {
            return sceneNames.IndexOf(sceneName);
        }

        int GetActiveSceneIndex() {
            return GetSceneIndexByName(GetActiveSceneName());
        }

        protected bool IsMainScene() {
            return GetActiveSceneIndex() < GetSceneIndexByName("Fin");
        }

        protected bool IsLastScene() {
            return GetActiveSceneIndex() == sceneNames.Count - 1;
        }

        protected void PrevScene() {
            int index = GetActiveSceneIndex();
            Assert.IsTrue(0 <= index);
            SceneManager.LoadScene(sceneNames[index - 1]);
        }

        protected void NextScene() {
            int index = GetActiveSceneIndex();
            Assert.IsTrue(0 <= index && index + 1 < sceneNames.Count);
            SceneManager.LoadScene(sceneNames[index + 1]);
        }

        void JumpScene(string sceneName) {
            int index = GetSceneIndexByName(sceneName);
            Assert.IsTrue(0 <= index);
            SceneManager.LoadScene(sceneNames[index]);
        }

        protected void TitleScene() {
            JumpScene("Title");
        }

        protected void CreditScene() {
            JumpScene("Credit");
        }

        protected void PlaceScene() {
            JumpScene("Place");
        }

        protected void AboutScene() {
            JumpScene("About");
        }
    }
}
