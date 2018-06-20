using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class musicamenu : MonoBehaviour {
	AudioSource playerAudio;
	public AudioClip parte2;
	public Image imagem;
	bool troca;

	void Start () {
		playerAudio = GetComponent <AudioSource> ();
		troca = false;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.L)){
			if (playerAudio.enabled) {
				playerAudio.enabled = false;
			} else {
				playerAudio.enabled = true;
			}
		}
		if(!troca && !imagem.enabled){
			playerAudio.clip = parte2;
			playerAudio.Play ();
			troca = true;
		}
	}
}
