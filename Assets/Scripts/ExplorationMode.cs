﻿using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;
using UnityEngine.UI;

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
    public static int sceneNumber;
    public GameObject helpButton;
    public float previousSize;

    private int goNumber;
    private float lastClickTime;
    private float timeSinceLastClick;
    private ObjectProperties objProp;
    private string headerKey;
    private string descKey;

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
                LeanIn();
                CloseBlend();
            }
            else if (!maskActive)
            {
                Buttons buttons = GameObject.Find("EventSystem").GetComponent<Buttons>();

                headerKey = "explo" + sceneNumber.ToString() + "_header" + objProp.objectNumber.ToString();//jest
                descKey = "explo" + sceneNumber.ToString() + "_desc" + objProp.objectNumber.ToString();

                MPanZoom.isOn = false;
                maskActive = true;
                this.gameObject.GetComponent<SpriteMask>().frontSortingOrder = 1;//niepotrzebne
                this.gameObject.tag = "ActiveObject";//jest
                GameObject[] objectsArray = GameObject.FindGameObjectsWithTag("ObjectToFind");//jest
                trans = this.transform;

                ProCamera2D.Instance.AddCameraTarget(trans);
                ProCamera2D.Instance.GetCameraTarget(trans).TargetOffset.x = objProp.CameraOffset.x;

                previousSize = Camera.main.orthographicSize;
                Debug.Log(previousSize);
                buttons.previousSize = Camera.main.orthographicSize;

                goNumber = this.gameObject.GetComponent<ObjectProperties>().objectNumber;
                this.gameObject.GetComponent<ModalMessages>().GetNewMessage(headerKey, descKey);//to prob można skrócić do ModalManagera, zmaiast messages -> manager
                OpenModal();
                LeanOut();

                for (int i = 0; i < objectsArray.Length; i++)
                {
                    objectsArray[i].gameObject.GetComponent<ExplorationMode>().isClickable = false;
                }

                helpButton.SetActive(false);
                blend.SetActive(true);

                Debug.Log(headerKey);
                Debug.Log(descKey);
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
        helpButton.SetActive(true);
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