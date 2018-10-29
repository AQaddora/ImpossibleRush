using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public static AudioSource audio;

	void Awake()
	{
		if (audio == null)
		{
			audio = GetComponent<AudioSource>();
			DontDestroyOnLoad(this.gameObject);
		}
		else
			Destroy(this.gameObject);
	}
}
