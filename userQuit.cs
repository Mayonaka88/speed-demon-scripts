using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class userQuit : MonoBehaviour
{
    public Animator transition;
    public Scene currentScene;
    public bool isWebApp;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            if (currentScene.buildIndex == 2 || currentScene.buildIndex == 1 || currentScene.buildIndex == 4)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    StartCoroutine(LoadLevel(0));
                }
            }
            else if (currentScene.buildIndex == 0)
            {
                if (isWebApp == false)
                {
                    Application.Quit();
                }
                
            }
            
        }

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            if (PlayerPrefs.HasKey("RS") == true)
            {
                if (PlayerPrefs.GetInt("RS") == 0)
                {
                    PlayerPrefs.SetInt("RS", 1);
                }
                else if(PlayerPrefs.GetInt("RS") == 1)
                {
                    PlayerPrefs.SetInt("RS", 0);
                }
            }
            else
            {
                PlayerPrefs.SetInt("RS", 0);
            }
        }

        IEnumerator LoadLevel(int index)
        {
            transition.SetTrigger("enterGame");

            yield return new WaitForSeconds(1f);

            SceneManager.LoadScene(index);
        }
    }
}
