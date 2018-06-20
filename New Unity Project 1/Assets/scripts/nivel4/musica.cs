using UnityEngine;
using System.Collections;

public class musica : MonoBehaviour {
	public GameObject jack;
	public AudioClip outramusica;
	bool troca = false;

	AudioSource playerAudio; 

	void Start () {
		playerAudio = GetComponent <AudioSource> ();
	}

	void Update () {
		if(!troca){
			if (jack.transform.position.y > 493) {
				playerAudio.clip = outramusica;
				playerAudio.Play ();
				troca = true;
			}
		}
	}
}
