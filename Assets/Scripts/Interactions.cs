using Com.LuisPedroFonseca.ProCamera2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour

{
    public int objectnr;
    public bool triggered = false;
    private GameObject triggeredObject;
    public Vector3 skala;
    public float windowLeftOffset;
    public float windowRightOffset;
    public bool openWindow = false;
    private float windowOffset;
    private float camOffset;
    public Camera GameCamera;
    private GameObject jstckFx;
    public Material selectedMat;
    private int numberOfObjectsToFind;
    private int lostHearts = 0;
    public GameObject mistake1;
    public GameObject mistake2;
    public GameObject mistake3;
    public static int allPlayableScenes = 5;
    public GameObject objectsToFindText;

    void Start()
    {
        jstckFx = GameObject.Find("JoystickFIxed"); //mobile joystick

        GameObject.Find("ClickButton").GetComponent<Tester>().GetNewMessage();
        GameObject.Find("CanvasNormal").GetComponent<ModalManager>().modalWindow.SetActive(false);

        numberOfObjectsToFind = GameObject.FindGameObjectsWithTag("ObjecToFind").Length;
        GameObject.Find("nrObjToFind").GetComponent<TextMeshProUGUI>().text = numberOfObjectsToFind.ToString();

        mistake1 = GameObject.Find("Mistake1");
        mistake2 = GameObject.Find("Mistake2");
        mistake3 = GameObject.Find("Mistake3");
    }

    private void Update()
    {
        //test
        if (GameObject.Find("nrObjToFind") != null)
        {
            GameObject.Find("nrObjToFind").GetComponent<TextMeshProUGUI>().text = numberOfObjectsToFind.ToString();
        }


        if (numberOfObjectsToFind == 0)
        {
            Buttons.CompletedGameSceneIndex = SceneManager.GetActiveScene().buildIndex;
            NextSceneTransition();
        }
    }


    public void CheckInteraction()
    {
        if (triggered == true)
        {
            if (openWindow == false)
            {
                OpeningWindow();
            }
            else
            {
                ClosingWindow();
                numberOfObjectsToFind--;
            }
        }
        else
        {
            // zła odpowiedź
            if (lostHearts < 3)
            {
                switch (lostHearts)
                {
                    case 0:
                        mistake1.GetComponent<Animator>().SetBool("IsOn", false);
                        lostHearts++;
                        break;
                    case 1:
                        mistake2.GetComponent<Animator>().SetBool("IsOn", false);
                        lostHearts++;
                        break;
                    case 2:
                        mistake3.GetComponent<Animator>().SetBool("IsOn", false);
                        lostHearts++;
                        break;
                }
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
        objectnr = collision.GetComponent<ObjectProperties>().objectNumber;

        if (triggeredObject == null)
        {
            triggeredObject = collision.gameObject;
        }

        if (triggeredObject.transform.position.x >= 0)
        {
            windowOffset = windowLeftOffset;
            camOffset = -0.5f;
        }
        else
        {
            windowOffset = windowRightOffset;
            camOffset = 0.5f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
        triggeredObject = null;

        GameCamera.GetComponent<ProCamera2D>().OffsetX = 0;
        camOffset = 0f;
        GameObject.Find("CanvasNormal").GetComponent<ModalManager>().modalWindow.SetActive(false);
    }

    private void NextSceneTransition()
    {
        SceneManager.LoadScene(1);
    }

    void OpeningWindow()
    {
        openWindow = true;
        GameObject.Find("ClickButton").GetComponent<Tester>().GetNewMessage();
        jstckFx.SetActive(false);
        LeanTween.alpha(GameObject.Find("ModalWindow").GetComponent<RectTransform>(), 0f, 0f);
        LeanTween.scale(GameObject.Find("ModalWindow"), skala, 0f);
        LeanTween.moveLocalX(GameObject.Find("ModalWindow"), windowOffset, 0f);
        LeanTween.scale(GameObject.Find("ModalWindow"), skala * 2f, 1f);
        LeanTween.alpha(GameObject.Find("ModalWindow").GetComponent<RectTransform>(), 1f, 2f);
        GameCamera.GetComponent<ProCamera2D>().OffsetX = camOffset;
        triggeredObject.GetComponent<SpriteRenderer>().material = selectedMat;
    }

    void ClosingWindow()
    {
        GameCamera.GetComponent<ProCamera2D>().OffsetX = 0;
        openWindow = false;
        GameObject.Find("CanvasNormal").GetComponent<ModalManager>().modalWindow.SetActive(false);
        jstckFx.SetActive(true);
        LeanTween.alpha(triggeredObject, 0f, 2f);
        Destroy(triggeredObject, 2f);
        triggered = false;
        GameObject.Find("RestOfIcon").GetComponent<BouncingIcon>().Bouncing();
    }
}
