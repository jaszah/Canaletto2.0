using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public static int CompletedSceneIndex = 0;

    public void NextGameScene()
    {
        if(CompletedSceneIndex < Interactions.allPlayableScenes)
        {
            Debug.Log("if w nextbutton");
            CompletedSceneIndex++;
            Debug.Log("Numer sceny w NextButton(z NextButton)" + CompletedSceneIndex);
            SceneManager.LoadScene(CompletedSceneIndex);
        }
        else
        {
            CompletedSceneIndex++;
            SceneManager.LoadScene(CompletedSceneIndex);
        }
    
    }
}
