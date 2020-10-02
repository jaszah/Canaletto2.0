using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

public class ExplorationMode : MonoBehaviour
{
    private const float DOUBLE_CLICK_TIME = .2f;

    public GameObject blend;
    public bool isClickable;
    public bool maskActive;
    public GameObject modalWindow;
    public Vector3 skala;
    public static bool isDoubleClick;
    public static Transform trans;
    public Camera cam;
    public float smoothSize;

    private int goNumber;
    private float lastClickTime;
    private float timeSinceLastClick;
    private ObjectProperties objProp;
    private float previousSize;

    SmoothingZoom smoothZ = new SmoothingZoom();

    private void Start()
    {
        isClickable = true;
        maskActive = false;
        isDoubleClick = false;

        objProp = this.gameObject.GetComponent<ObjectProperties>();
    }

    private void OnMouseDown()
    {
        //Double click check
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

        //doin things
        if (isClickable && isDoubleClick)
        {
            if (maskActive)
            {
                ProCamera2D.Instance.RemoveCameraTarget(trans);

                LeanTween.value(cam.gameObject, cam.orthographicSize, previousSize, 2f).setOnUpdate((float flt) => {
                    cam.orthographicSize = flt;
                });

                CloseBlend();
            }
            else if (!maskActive)
            {
                MPanZoom.isOn = false;
                maskActive = true;
                this.gameObject.GetComponent<SpriteMask>().frontSortingOrder = 1;
                this.gameObject.tag = "ActiveObject";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");
                trans = this.transform;

                ProCamera2D.Instance.AddCameraTarget(trans);
                ProCamera2D.Instance.GetCameraTarget(trans).TargetOffset.x = objProp.CameraOffset.x;

                previousSize = Camera.main.orthographicSize;
                LeanTween.value(cam.gameObject, cam.orthographicSize, objProp.zoomSize, 1.7f).setOnUpdate((float flt) => {
                    cam.orthographicSize = flt;
                });

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