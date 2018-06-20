using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class musicianlife : MonoBehaviour {
	public int vidainicial = 500;
	public int vidasobrando = 0;
	public bool help = false;
	public AudioClip jackmorte;
	public bool death = false;

	bool isdead;
	bool damaged;

	AudioSource playerAudio;
	spawnmusician life;

	void Start () {
		life = FindObjectOfType (typeof(spawnmusician)) as spawnmusician;
		vidasobrando = vidainicial;
		playerAudio = GetComponent <AudioSource> ();
		death = false;
		help = false;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "other"){
			takedamage (25);
		}
	}

	void Update () {
		life.vidasobrando = vidasobrando;
		life.death = death;
		life.help = help;
		if (death && !help) {
			isdead = true;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
			help = true;
		}
	}

	public void takedamage (int dor){
		damaged = true;
		vidasobrando -= dor;
		playerAudio.Play ();
		if (vidasobrando <= 0 && !isdead) {
			death = true;
		}
	}
}
