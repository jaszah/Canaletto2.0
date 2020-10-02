using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothingZoom
{
	public void SmoothZooming(float targetSize, float smoothingSpeed = 0.1f)
	{
		Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, targetSize, smoothingSpeed * Time.deltaTime);
		Debug.Log(targetSize);
	}
}
