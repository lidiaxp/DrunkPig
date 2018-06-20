using UnityEngine;
using System.Collections;

public class tirotras : MonoBehaviour {
	public GameObject laser;
	
	AudioSource playerAudio;

	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Y)) {
			playerAudio.Play ();
			Instantiate (laser, transform.position, transform.rotation);
		}
	}
}
