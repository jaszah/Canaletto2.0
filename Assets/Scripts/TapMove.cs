using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapMove : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)//i jeśli nie klepneło się buttona w dolnym rogu i trzech pasków chyba po xiy
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;
            Debug.Log(touchPos);
            if (touch.phase == TouchPhase.Ended)
            {
                transform.position = touchPos;
            }
        }
    }
}
