using UnityEngine;
using System.Collections;

public class tiropratras2 : MonoBehaviour {
	public GameObject laser;

	AudioSource playerAudio;

	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){
			playerAudio.Play ();
			Instantiate(laser, transform.position, transform.rotation);
		}
	}
}
