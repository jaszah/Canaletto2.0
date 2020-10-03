using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public void LoadNextScene(int scene)
    {
        Debug.Log(scene);
        StartCoroutine(LoadLevel(scene));
    }

    IEnumerator LoadLevel(int scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(scene);
    }
}
