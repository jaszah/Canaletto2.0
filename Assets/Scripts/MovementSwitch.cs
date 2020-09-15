using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSwitch : MonoBehaviour
{
	private bool joystickMove;
	private bool tapMove;

	private void Start()
	{
		joystickMove = true;
		tapMove = false;
	}

	public void SwitchToJoystick()
	{
		this.GetComponent<PointOfInterestMove>().enabled = true;
		this.GetComponent<TapMove>().enabled = false;

		joystickMove = true; //włączyć kod na tym obiekcie
		tapMove = false; //wyłączyć kod na tym obiekcie
		Debug.Log("joystick");
	}

	public void SwitchToTap()
	{
		this.GetComponent<PointOfInterestMove>().enabled = false;
		this.GetComponent<TapMove>().enabled = true;

		joystickMove = false; //to samo co wyżej
		tapMove = true;//to samo co wyżej
		Debug.Log("tap");
	}

	public void TurnOffTap()
	{
		if (tapMove)
		{
			this.GetComponent<TapMove>().enabled = false;
			Debug.Log("Off");
		}
	}
	public void TurnOnTap()
	{
		if (tapMove)
		{
			this.GetComponent<TapMove>().enabled = true;
			Debug.Log("On");
		}
	}
}
