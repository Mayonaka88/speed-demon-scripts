using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameLoader : MonoBehaviour
{
    public Animator transition;
    public void loading()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("enterGame");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Death Screen");
    }
}
