using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
	AudioSource playerAudio;

	void Start () {
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
	}
}
