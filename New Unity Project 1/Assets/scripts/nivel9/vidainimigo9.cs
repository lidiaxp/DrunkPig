using UnityEngine;
using System.Collections;

public class vidainimigo9 : MonoBehaviour {
	AudioSource playerAudio; 
	spawnmusician pontos;

	void Start () {
		playerAudio = GetComponent <AudioSource> ();
		pontos = FindObjectOfType (typeof(spawnmusician)) as spawnmusician;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "other"){
			Destroy (gameObject);
			pontos.ponto += 1;
			playerAudio.Play ();
		}
	}

	void Update () {

	}
}
