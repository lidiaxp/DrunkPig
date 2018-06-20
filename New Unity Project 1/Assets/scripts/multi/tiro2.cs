using UnityEngine;
using System.Collections;

public class tiro2 : MonoBehaviour {
	public GameObject laser;

	AudioSource playerAudio;
	
	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.V)) {
			playerAudio.Play ();
			Instantiate (laser, transform.position, transform.rotation);
		}
	}
}
