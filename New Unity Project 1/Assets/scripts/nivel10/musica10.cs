using UnityEngine;
using System.Collections;

public class musica10 : MonoBehaviour {
	AudioSource playerAudio;
	public AudioClip parte2;
	public bool musica = false;

	colher colhera;

	void Start () {
		colhera = FindObjectOfType (typeof(colher)) as colher;
		playerAudio = GetComponent <AudioSource> ();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.L)){
			if (playerAudio.enabled) {
				playerAudio.enabled = false;
			} else {
				playerAudio.enabled = true;
			}
		}
		if(musica){
			playerAudio.clip = parte2;
			playerAudio.Play ();
			musica = false;
		}
	}
}
