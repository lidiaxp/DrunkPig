using UnityEngine;
using System.Collections;

public class animalsound : MonoBehaviour {
	AudioSource playerAudio;

	void Start () {
		playerAudio = GetComponent <AudioSource> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "Water"){
			playerAudio.Play ();
		}
	}

	void Update () {
	
	}
}
