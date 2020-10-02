using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public static int CompletedGameSceneIndex = 0;
    public static int CompletedExplorationSceneIndex = 0;

    public static int FirstGameSceneIndex = 2;
    public static int FirstExplorationSceneIndex = 13;

    private int EndScene = 7;

    public static bool gameMode = true;

    public void NextGameScene()
    {
        if (gameMode)
        {
            if (CompletedGameSceneIndex < Interactions.allPlayableScenes)
            {
                CompletedGameSceneIndex++;
                SceneManager.LoadScene(CompletedGameSceneIndex);
            }
            else
            {
                SceneManager.LoadScene(EndScene);
            }
        }
        else
        {
            if ((CompletedExplorationSceneIndex - 6) < Interactions.allPlayableScenes)
            {
                CompletedExplorationSceneIndex++;
                SceneManager.LoadScene(CompletedExplorationSceneIndex);
            }
            else
            {
                SceneManager.LoadScene(EndScene);
            }
        }
    
    }

    public void GameMode()
    {
        gameMode = true;
        StartGameScene();
    }

    public void ExploMode()
    {
        gameMode = false;
        StartGameScene();
    }

    public void StartGameScene()
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

    public void CloseBlendButton()
    {
        GameObject.FindGameObjectWithTag("ActiveObject").GetComponent<ExplorationMode>().maskActive = false;
        ExplorationMode.isDoubleClick = false;
        ProCamera2D.Instance.RemoveCameraTarget(ExplorationMode.trans);

        GameObject.FindGameObjectWithTag("ActiveObject").GetComponent<SpriteMask>().frontSortingOrder = -1;
        GameObject.FindGameObjectWithTag("ActiveObject").gameObject.tag = "ObjectToFind";
        GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");

        GameObject.Find("ModalWindow").SetActive(false);

        for (int i = 0; i < objectsArray.Length; i++)
        {
            objectsArray[i].gameObject.GetComponent<ExplorationMode>().isClickable = true;
        }

        GameObject.Find("blend").SetActive(false);
        MPanZoom.isOn = true;

    }

    public void StartExScene()
    {
        SceneManager.LoadScene(PaintingChange.exSceneName);
    }

    public void SetGameMode()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
