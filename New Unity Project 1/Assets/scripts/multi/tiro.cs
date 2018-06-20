using UnityEngine;
using System.Collections;

public class tiro : MonoBehaviour {
	public GameObject laser;

	AudioSource playerAudio;  

	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) {
			playerAudio.Play ();
			Instantiate (laser, transform.position, transform.rotation);
		}
	}
}
