using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GameObject loadIcon;
    public Text progressText;

    void Start()
    {
        LoadLevel(2);
    }

    // Update is called once per frame
    void Update () {
        loadIcon.transform.Rotate(loadIcon.transform.rotation.x, loadIcon.transform.rotation.y, loadIcon.transform.rotation.z - 1f);

        if(loadIcon.transform.rotation.z <= -1f)
        {
            loadIcon.transform.rotation = new Quaternion(0, 0, 0, 0);
        }

	}

    ///-------LOAD SCREEN--------------------

    public void LoadLevel(int myScene)
    {
        loadIcon.SetActive(true);
        StartCoroutine(LoadAsyncScene(myScene));
    }

    IEnumerator LoadAsyncScene(int myScene)
    {
        AsyncOperation aOperation = SceneManager.LoadSceneAsync(myScene);

        while (!aOperation.isDone)
        {
            float progress = Mathf.Clamp01(aOperation.progress / 0.9f);

            progressText.text = progress * 100f + "%";

            yield return null;

        }
    }
}
