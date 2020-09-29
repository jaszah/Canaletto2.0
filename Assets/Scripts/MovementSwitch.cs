using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSwitch : MonoBehaviour
{
	public void SwitchToJoystick()
	{
		this.GetComponent<PointOfInterestMove>().enabled = true;
		this.GetComponent<MPanZoom>().enabled = false;

		//a tu powłączać jeśli były wyłączone

		Debug.Log("joystick");
	}

	public void SwitchToZoom()
	{
		this.GetComponent<PointOfInterestMove>().enabled = false;
		this.GetComponent<MPanZoom>().enabled = true;

		//trzeba powyłączać POIa, joysticka i przycisk po prawej

		Debug.Log("zoom");
	}

}
