using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingIcon : MonoBehaviour
{

    public Vector3 maxSize;
    public Vector3 stdSize;


    public void Bouncing()
    {
        LeanTween.scale(this.gameObject, maxSize, 0.8f).setEaseInOutCubic().setLoopPingPong(2);
    }
}
