using UnityEngine;
using System.Collections;

public class enemylife : MonoBehaviour {

	AudioSource playerAudio; 
	pontos pontos;

	void Start () {
		playerAudio = GetComponent <AudioSource> ();
		pontos = FindObjectOfType (typeof(pontos)) as pontos;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Bala"){
			Destroy (gameObject);
			pontos.ponto += 1;
			playerAudio.Play ();
		}
	}

	void Update () {
	
	}
}
