using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public Animator transition;
    public Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        
    }
    void Update()
    {
        if (currentScene.buildIndex == 2 || currentScene.buildIndex == 4)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadLevel(3));
            }
        }
        else if (currentScene.buildIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadLevel(4));
            }
        }
    }

    IEnumerator LoadLevel(int index)
    {
        transition.SetTrigger("enterGame");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(index);
    }
}
