using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    public Camera cam;
    public GameObject modalWindow;
    public GameObject syrenka1;
    public GameObject syrenka2;
    public GameObject syrenka3;
    public Material material;
    public Vector3 modalOffsetVector;
    public bool isClickable = true;
    public bool modalActive = false;
    public float previousSize;
    public int lostHearts = 0;

    public static Transform trans;
    public static int sceneNumber;
    public static bool isDoubleClick = false;
    public static bool winOpened = false;


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
            timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                isDoubleClick = true;
                //Debug.Log("dobule od gamemode");
            }

            lastClickTime = Time.time;
        }

        if(isClickable && isDoubleClick)
        {
            //ClickChecker.openWinStarted = true;//a tutaj gdzieś trzeba sprawdzać tam gdzies na dole czy sie cos otwierać ma i jesli tak i jeśli zmienna z clickera jest true to trzeba uruchomić funkcje tutaj napisaną
            //Debug.Log(ClickChecker.openWinStarted);
            winOpened = true;

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

                //ClickChecker.openWinStarted = false;
                MPanZoom.isOn = true;
                modalActive = false;
                isDoubleClick = false;
            }
            else
            {
                Buttons buttons = GameObject.Find("EventSystem").GetComponent<Buttons>();
                ModalManager modalMan = GameObject.Find("CanvasNormal").GetComponent<ModalManager>();

                this.GetComponent<SpriteRenderer>().material = material;

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
                modalWindow.transform.localPosition = modalOffsetVector;

                headerKey = "game" + sceneNumber.ToString() + "_header" + objProp.objectNumber.ToString();
                descKey = "game" + sceneNumber.ToString() + "_desc" + objProp.objectNumber.ToString();
                modalMan.ShowModal(headerKey, descKey);
                modalMan.body.transform.localPosition = new Vector3(-253, 0, 0);
                OpenModal();
                LeanOut();

                MPanZoom.isOn = false;
                modalActive = true;
                isDoubleClick = false;
            }
        }
    }

    private void Update()
    {
        //Debug.Log("clicked z gamemode: " + ClickChecker.clicked);
        //Debug.Log("winopened: " + winOpened);
        if (ClickChecker.clicked && !winOpened)
        {
            //Debug.Log(openWinStarted);
            if (lostHearts < 3)
            {
                switch (lostHearts)
                {
                    case 0:
                        syrenka1.GetComponent<Animator>().SetBool("IsOn", false);
                        Destroy(syrenka1, 2.5f);
                        lostHearts++;
                        //Debug.Log(openWinStarted);
                        //openWinStarted = false;
                        break;
                    case 1:
                        syrenka2.GetComponent<Animator>().SetBool("IsOn", false);
                        Destroy(syrenka2, 2.5f);
                        lostHearts++;
                        //openWinStarted = false;
                        break;
                    case 2:
                        syrenka3.GetComponent<Animator>().SetBool("IsOn", false);
                        Destroy(syrenka3, 2.5f);
                        lostHearts++;
                        //openWinStarted = false;
                        break;
                }
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        winOpened = false;
        ClickChecker.clicked = false;
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
        LeanTween.value(cam.gameObject, cam.orthographicSize, previousSize, .5f).setOnUpdate((float flt) => {
            cam.orthographicSize = flt;
        });
    }
}
