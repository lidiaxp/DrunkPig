using UnityEngine;
using System.Collections;

public class baconattack : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;     
	public int attackDamage = 5; 
	public AudioClip bacontiro;
	
	GameObject player;
	jacklife vida; 
	bool playerInRange; 
	float timer;
	AudioSource playerAudio; 
	
	void Awake (){
		player = GameObject.FindGameObjectWithTag ("Player");
		vida = player.GetComponent <jacklife> ();
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
	
	
	void Update (){
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
