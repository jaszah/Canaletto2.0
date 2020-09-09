using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplorationMode : MonoBehaviour
{
	public static int objectsCount = 19;

	private void Start()
	{
		objectsCount = GameObject.FindGameObjectsWithTag("ObjecToFind").Length;
		Debug.Log(objectsCount);
	}

	private void OnMouseDown()
	{
		this.gameObject.SetActive(false);
		objectsCount--;

		if (objectsCount == 0)
		{
			Debug.Log("end game");
			Buttons.CompletedExplorationSceneIndex = SceneManager.GetActiveScene().buildIndex;
			NextSceneTransition();
		}
	}
	private void NextSceneTransition()
	{
		SceneManager.LoadScene(1);
	}
}
