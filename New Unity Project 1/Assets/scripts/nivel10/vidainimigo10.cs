using UnityEngine;
using System.Collections;

public class vidainimigo10 : MonoBehaviour {
	AudioSource playerAudio;

	void Start () {
		playerAudio = GetComponent <AudioSource> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "other"){
			Destroy (gameObject);
			playerAudio.Play ();
		}
	}

	void Update () {

	}
}
