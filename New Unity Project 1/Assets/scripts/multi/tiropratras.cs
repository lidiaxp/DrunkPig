using UnityEngine;
using System.Collections;

public class tiropratras : MonoBehaviour {
	public GameObject laser;

	AudioSource playerAudio;
	
	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.K)){
			playerAudio.Play ();
			Instantiate(laser, transform.position, transform.rotation);
		}
	}
}
