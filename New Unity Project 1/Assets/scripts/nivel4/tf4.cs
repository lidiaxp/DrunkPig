using UnityEngine;
using System.Collections;

public class tf4 : MonoBehaviour {

	public GameObject laser;
	lifefrasco lifefrasco;
	AudioSource playerAudio;
	
	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
		lifefrasco = FindObjectOfType (typeof(lifefrasco)) as lifefrasco;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			playerAudio.Play ();
			Instantiate (laser, transform.position, transform.rotation);
		}
	}	
}
