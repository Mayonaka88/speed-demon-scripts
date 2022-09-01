using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingManager : MonoBehaviour
{
    public Image progressBar;
    public Animator transition;
    public Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
        
        currentScene = SceneManager.GetActiveScene();
        StartCoroutine(loadAsyncOperation());
    }

    IEnumerator loadAsyncOperation()
    {
        yield return new WaitForSeconds(1f);
        AsyncOperation levelLoad = SceneManager.LoadSceneAsync(1);
        while (levelLoad.progress < 1)
        {
            progressBar.fillAmount = levelLoad.progress;
            yield return new WaitForEndOfFrame();
        }
        transition.SetTrigger("enterGame");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }


}
