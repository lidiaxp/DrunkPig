using UnityEngine;
using System.Collections;

public class agua : MonoBehaviour {
	public int water;
	public AudioClip glub;

	AudioSource playerAudio;

	void Awake () {
		water = 0;
		playerAudio = GetComponent <AudioSource> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Water"){
			water++;
			playerAudio.clip = glub;
			playerAudio.Play ();
		}
	}

	void Update () {

	}
}
