using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplorationMode : MonoBehaviour
{
	public static int objectsCount = 19;
	public GameObject blend;
	public GameObject masks;
	//public GameObject button;

	private static string objectName;

	private void Start()
	{
		objectsCount = GameObject.FindGameObjectsWithTag("ObjecToFind").Length;
	}

	private void OnMouseDown()
	{
		this.gameObject.GetComponent<SpriteMask>().isCustomRangeActive = false;
		blend.SetActive(true);

		objectName = this.gameObject.name;

		PrintText();

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

    private void PrintText()
    {
        //tutaj wstawić tekst
        //button.SetActive(true);
    }

    public static void SetVisible(string name)
	{
		GameObject.Find(name).gameObject.GetComponent<SpriteMask>().isCustomRangeActive = true;
	}

	public void OkButton()
	{
		masks.SetActive(true);
		blend.SetActive(false);

		GameObject.Find(objectName).GetComponent<SpriteMask>().isCustomRangeActive = true;
	}
}
