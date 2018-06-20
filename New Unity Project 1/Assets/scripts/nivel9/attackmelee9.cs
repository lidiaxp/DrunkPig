using UnityEngine;
using System.Collections;

public class attackmelee9 : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;     
	public int attackDamage = 35; 
	public AudioClip bacontiro;

	GameObject player;
	life9 vida; 
	bool playerInRange; 
	float timer;
	AudioSource playerAudio;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		vida = player.GetComponent <life9> ();
		playerAudio = GetComponent <AudioSource> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject == player){
			playerInRange = true;
		}
	}
		
	void OnTriggerExit (Collider other){
		if(other.gameObject == player){
			playerInRange = false;
		}
	}

	void Update () {
		timer += Time.deltaTime;
		if(timer >= timeBetweenAttacks && playerInRange){
			Attack ();
		}
	}

	void Attack (){
		timer = 0f;
		if(vida.vidasobrando > 0){
			playerAudio.clip = bacontiro;
			playerAudio.Play ();
			vida.takedamage (attackDamage);
		}
	}
}
