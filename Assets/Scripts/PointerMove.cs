using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMove : MonoBehaviour
{

    private GameObject PointOfInterest;
    public Camera CameraMain;


    // Start is called before the first frame update
    void Start()
    {
       PointOfInterest = GameObject.Find("PointOfInterest");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PointerPosition = CameraMain.WorldToScreenPoint(PointOfInterest.transform.position, Camera.MonoOrStereoscopicEye.Mono);
        transform.position = PointerPosition;

    }
}
