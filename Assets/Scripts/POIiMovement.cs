using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POIMovement : MonoBehaviour {
    public float speed = 10.0f;
    public Transform POItransform;
    public GameObject interactWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        MovePOI(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
    }

    void MovePOI(Vector2 direction){
         POItransform.Translate(direction * speed * Time.deltaTime);
    }


}
