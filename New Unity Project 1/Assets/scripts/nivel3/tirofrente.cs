using UnityEngine;
using System.Collections;

public class tirofrente : MonoBehaviour {
	public GameObject laser;
	
	AudioSource playerAudio;
	
	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			playerAudio.Play ();
			Instantiate (laser, transform.position, transform.rotation);
		}
	}
}
