using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public static int CompletedGameSceneIndex = 0;
    public static int CompletedExplorationSceneIndex = 0;

    public static int FirstGameSceneIndex = 2;
    public static int FirstExplorationSceneIndex = 6;

    private int EndScene = 7;

    public static bool gameMode = true;

    public void NextGameScene()
    {
        if(CompletedGameSceneIndex < Interactions.allPlayableScenes)
        {
            Debug.Log("if w nextbutton");
            CompletedGameSceneIndex ++;
            Debug.Log("Numer sceny w NextButton(z NextButton)" + CompletedGameSceneIndex);
            SceneManager.LoadScene(CompletedGameSceneIndex);
        }
        else
        {
            CompletedGameSceneIndex ++;
            SceneManager.LoadScene(EndScene);
        }
    
    }

    public void GameMode()
    {
        gameMode = true;
        StartGameScene();
    }

    public void ExplorationMode()
    {
        gameMode = false;
        StartGameScene();
    }

    public void Test()
    {
        Debug.Log("test");
    }

    private void StartGameScene()
    {
        if (gameMode)
        {
            SceneManager.LoadScene(FirstGameSceneIndex);
        }
        else
        {
            SceneManager.LoadScene(FirstExplorationSceneIndex);
        }
    }
}
