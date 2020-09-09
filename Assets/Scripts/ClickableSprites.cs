using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableSprites : MonoBehaviour
{
	private void OnMouseDown()
	{
		this.gameObject.SetActive(false);

	}
}
