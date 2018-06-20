using UnityEngine;
using System.Collections;

public class pontuaçao : MonoBehaviour {
	public int fazendas;
	public int fabricas;
	public AudioClip nhac;
	public AudioClip bam;
	public AudioClip boom;

	AudioSource playerAudio;

	void Awake () {
		fazendas = 0;
		fabricas = 0;
		playerAudio = GetComponent <AudioSource> ();
	}

	void Update () {
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Farm"){
			playerAudio.clip = bam;
			playerAudio.Play ();
		}
		if(other.gameObject.tag == "FactoryC"){
			playerAudio.clip = boom;
			playerAudio.Play ();
		}
		if(other.gameObject.tag == "FactoryF"){
			playerAudio.clip = nhac;
			playerAudio.Play ();
		}
	}
}
