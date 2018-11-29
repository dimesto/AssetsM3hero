using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{

    public Scrollbar loadingProgbar;

    // Use this for initialization
    void Awake()
    {
        loadingProgbar = GetComponent<Scrollbar>();
        StartCoroutine(LoadScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoadScene()
    {
        //string sceneName = PlayerPrefs.GetString("Map");

        string sceneName = Save.info.MapName;

        AsyncOperation  loadScene = SceneManager.LoadSceneAsync(sceneName,LoadSceneMode.Single);

        while (!loadScene.isDone)
        {
            //Debug.Log(loadScene.progress);

            loadingProgbar.value = loadScene.progress;
            yield return null;
            // do something else
        }

        //loadScene.allowSceneActivation = true;


        yield return null;
    }
}
