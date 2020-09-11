using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplorationMode : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    public GameObject blend;
    public bool isClickable;
    public bool maskActive;

    private int sortingOrder;
    private int layerIndex;
    //private GameObject[] objectsArray;

    private void Start()
    {
        layerIndex = LayerMask.NameToLayer("ObjectsToFind");
        isClickable = true;
        maskActive = false;

        //GameObject[] objectsArray = FindGameObjectsInLayer(layerIndex);
    }

    private void Update()
    {
        sortingOrder = this.gameObject.GetComponent<SpriteMask>().frontSortingOrder;
    }

    private void OnMouseDown()
    {
        if (isClickable)
        {
            if (maskActive)
            {
                maskActive = false;
                this.gameObject.GetComponent<SpriteMask>().frontSortingOrder = -1;
                this.gameObject.tag = "ObjectsToFind";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectsToFind");


                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<ExplorationMode>().isClickable = true;
                }

                blend.SetActive(false);
            }
            else if(!maskActive)
            {
                maskActive = true;
                this.gameObject.GetComponent<SpriteMask>().frontSortingOrder = 1;
                this.gameObject.tag = "ActiveObject";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectsToFind");

                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<ExplorationMode>().isClickable = false;
                }

                blend.SetActive(true);
            }
        }
        else
        {
            return;
        }
    }
>>>>>>> 1aaee6ee893bc7445f9459f5ae34c3ed15331384
}
