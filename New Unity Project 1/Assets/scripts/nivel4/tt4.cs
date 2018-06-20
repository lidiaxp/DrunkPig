using UnityEngine;
using System.Collections;

public class tt4 : MonoBehaviour {
	public GameObject laser;
	lifefrasco lifefrasco;
	AudioSource playerAudio;
	public GameObject frasco;
	
	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
		lifefrasco = frasco.GetComponent<lifefrasco> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Y)) {
			playerAudio.Play ();
			Instantiate (laser, transform.position, transform.rotation);
		}
	}
	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Potion"){
			lifefrasco.takedamage(10);
		}
	}
}
