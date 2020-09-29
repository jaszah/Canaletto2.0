
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplorationMode : MonoBehaviour
{
    private const float DOUBLE_CLICK_TIME = .2f;

    public GameObject blend;
    public bool isClickable;
    public bool maskActive;
    public GameObject modalWindow;
    public Vector3 skala;
    public static bool isDoubleClick;

    private GameObject objToFind;
    private int layerIndex;
    private int goNumber;
    private float lastClickTime;
    private float timeSinceLastClick;

    private void Start()
    {
        layerIndex = LayerMask.NameToLayer("ObjectsToFind");
        isClickable = true;
        maskActive = false;
        isDoubleClick = false;
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("normal");
        //    timeSinceLastClick = Time.time - lastClickTime;

        //    if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
        //    {
        //        isDoubleClick = true;
        //        Debug.Log("double");
        //    }

        //    lastClickTime = Time.time;
        //}
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("normal");
            timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                isDoubleClick = true;
                Debug.Log("double");
            }

            lastClickTime = Time.time;
        }
        if (isClickable && isDoubleClick)
        {
            Debug.Log("double: " + isDoubleClick);
            if (maskActive)
            {
                CloseBlend();
            }
            else if (!maskActive)
            {
                MPanZoom.isOn = false;
                maskActive = true;
                this.gameObject.GetComponent<SpriteMask>().frontSortingOrder = 1;
                this.gameObject.tag = "ActiveObject";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");

                goNumber = this.gameObject.GetComponent<ObjectProperties>().objectNumber;
                this.gameObject.GetComponent<Tester>().GetNewMessageExplore(goNumber);
                OpenModal();

                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<ExplorationMode>().isClickable = false;
                }

                blend.SetActive(true);
            }
        }
    }

    private void OpenModal()
    {
        LeanTween.alpha(GameObject.Find("ModalWindow").GetComponent<RectTransform>(), 0f, 0f);
        LeanTween.alpha(GameObject.Find("ModalWindow").GetComponent<RectTransform>(), 1f, 2f);
    }

    public void CloseBlend()
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
        MPanZoom.isOn = true;
        isDoubleClick = false;
    }
}