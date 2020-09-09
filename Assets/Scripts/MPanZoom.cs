using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MPanZoom : MonoBehaviour
{
    Vector3 touchStart;
    public float zoomOutMin = 1;
    public float zoomOutMax = 15;
    public float ImageXsize = 3989; //rozmiar obrazu w pixelach X - do przerobienia na automatyczne pobieranie ze wskazanego sprite'a
    public float ImageYsize = 3121; //rozmiar obrazu w pixelach Y
    public int PixelsPerUnit = 100; //to co sprite ma tam wstawione - do przerobienia na automatyczne pobieranie ze wskazanego sprite'a
    private float leftMargin;
    private float rightMargin;
    private float topMargin;
    private float bottomMargin;
    private float camPosX;
    private float camPosY;
    public float screenRatio; // 0.5625f
    public float screenRatioInv;
    public float screenXsize;  
    public float screenYsize;
    public float ZoomValue;
    public float multiply;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    {
        leftMargin = ImageXsize / PixelsPerUnit / -2; //lewa krawędź obrazka
        rightMargin = ImageXsize / PixelsPerUnit / 2;
        topMargin = ImageYsize / PixelsPerUnit / 2;
        bottomMargin = ImageYsize / PixelsPerUnit / -2;
        screenXsize = Screen.width;
        screenYsize = Screen.height;
        screenRatio = screenXsize / screenYsize;
        if (Screen.width > Screen.height)
        {
            zoomOutMax = ImageXsize / PixelsPerUnit / 2 / screenRatio;
        }
        if (Screen.height >= Screen.width)
        {
            zoomOutMax = ImageYsize / PixelsPerUnit / 2;
        }
        ZoomValue = Camera.main.orthographicSize;
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction; //oblicza pozycje kamery po przesunieciu
        }
        zoom(Input.GetAxis("Mouse ScrollWheel") * multiply);
        camPosX = Mathf.Clamp(Camera.main.transform.position.x, leftMargin + (ZoomValue * screenRatio), rightMargin - (ZoomValue * screenRatio)); //oblicza pozycje kamery X wewnątrz obrazu uwzgledniajac margines zooma
        camPosY = Mathf.Clamp(Camera.main.transform.position.y, bottomMargin + ZoomValue, topMargin - ZoomValue); //oblicza pozycje kamery Y wewnątrz obrazu uwzgledniajac margines zooma
        Camera.main.transform.position = new Vector3(camPosX, camPosY, -10); //przestawia kamere z poprzedniej pozycji na tą wewnątrz
        
    }
    void zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
