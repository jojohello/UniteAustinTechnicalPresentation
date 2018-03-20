using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayScript : MonoBehaviour {


	void Start()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}

}
