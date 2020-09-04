using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlumSounds : MonoBehaviour
{
	public AudioClip plumSound;
	public AudioSource audioSource;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>(); 
	}

	private void MakePlumSound()
	{
		audioSource.PlayOneShot(plumSound);
	}
}
