using UnityEngine;
using System.Collections;

public class somacelerar : MonoBehaviour {
	AudioSource audio;

	void Start () {
		audio = GetComponent <AudioSource> ();
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			audio.Play ();
		}
	}
}
