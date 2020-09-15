
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplorationMode : MonoBehaviour
{
    public GameObject blend;
    public bool isClickable;
    public bool maskActive;
    public GameObject modalWindow;

    private GameObject objToFind;
    private int sortingOrder;
    private int layerIndex;
    private int goNumber;
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
                this.gameObject.tag = "ObjectToFind";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");

                modalWindow.SetActive(false);

                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<ExplorationMode>().isClickable = true;
                }

                blend.SetActive(false);
            }
            else if (!maskActive)
            {
                maskActive = true;
                this.gameObject.GetComponent<SpriteMask>().frontSortingOrder = 1;
                this.gameObject.tag = "ActiveObject";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");

                goNumber = this.gameObject.GetComponent<ObjectProperties>().objectNumber;
                this.gameObject.GetComponent<Tester>().GetNewMessageExplore(goNumber);

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
}