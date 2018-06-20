using UnityEngine;
using System.Collections;

public class tiropratras10 : MonoBehaviour {
	public GameObject laser;
	public float timeBetweenAttacks = 0.7f; 

	float timer;

	AudioSource playerAudio;

	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.T)){
			timer += Time.timeSinceLevelLoad;
			if(timer >= timeBetweenAttacks){
				playerAudio.Play ();
				Instantiate (laser, transform.position, transform.rotation);
			}
		}
	}
}
