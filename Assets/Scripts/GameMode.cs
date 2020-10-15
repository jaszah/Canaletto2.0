using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public Camera cam;
    public GameObject modalWindow;
    public Material material;
    public bool isClickable = true;
    public bool modalActive = false;
    public float previousSize;

    public static Transform trans;
    public static int sceneNumber;
    public static bool isDoubleClick = false;

    private static float DOUBLE_CLICK_TIME = .2f;

    private float timeSinceLastClick;
    private float lastClickTime;
    private string headerKey;
    private string descKey;
    private ObjectProperties objProp;

    private void Start()
    {
        objProp = this.gameObject.GetComponent<ObjectProperties>();
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

        if(isClickable && isDoubleClick)
        {
            if (modalActive)
            {
                ProCamera2D.Instance.RemoveCameraTarget(trans);

                LeanIn();

                LeanTween.alpha(this.gameObject, 0f, 1f);
                Destroy(this.gameObject, 1f);

                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");

                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<GameMode>().isClickable = true;
                }

                modalWindow.SetActive(false);

                MPanZoom.isOn = true;
                modalActive = false;
                isDoubleClick = false;
            }
            else
            {
                Buttons buttons = GameObject.Find("EventSystem").GetComponent<Buttons>();

                this.GetComponent<SpriteRenderer>().material = material;

                headerKey = "game" + sceneNumber.ToString() + "_header" + objProp.objectNumber.ToString();
                descKey = "game" + sceneNumber.ToString() + "_desc" + objProp.objectNumber.ToString();

                this.gameObject.tag = "ActiveObject";
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");

                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<GameMode>().isClickable = false;
                }

                trans = this.transform;
                previousSize = Camera.main.orthographicSize;
                Debug.Log(previousSize);
                buttons.previousSize = Camera.main.orthographicSize;

                ProCamera2D.Instance.AddCameraTarget(trans);
                ProCamera2D.Instance.GetCameraTarget(trans).TargetOffset.x = objProp.CameraOffset.x;

                this.gameObject.GetComponent<ModalMessages>().GetNewMessage(headerKey, descKey);
                OpenModal();
                LeanOut();

                MPanZoom.isOn = false;
                modalActive = true;
            }
        }
    }

    private void OpenModal()
    {
        LeanTween.alpha(GameObject.Find("ModalWindow").GetComponent<RectTransform>(), 0f, 0f);
        LeanTween.alpha(GameObject.Find("ModalWindow").GetComponent<RectTransform>(), 1f, 2f);
    }
    public void LeanOut()
    {
        LeanTween.value(cam.gameObject, cam.orthographicSize, objProp.zoomSize, .5f).setOnUpdate((float flt) => {
            cam.orthographicSize = flt;
        });
    }

    public void LeanIn()
    {
        Debug.Log(previousSize);
        LeanTween.value(cam.gameObject, cam.orthographicSize, previousSize, .5f).setOnUpdate((float flt) => {
            cam.orthographicSize = flt;
        });
    }
}
