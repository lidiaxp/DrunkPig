using UnityEngine;
using System.Collections;

public class enemyattackrange : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;     
	public int attackDamage = 5; 
	public GameObject oldparr;
	public AudioClip linguicatiro;
	
	GameObject player;
	GameObject player2;
	vida vida; 
	vida2 vidar;
	bool playerInRange;   
	bool playerInRange2; 
	float timer;
	float timer2;
	AudioSource playerAudio; 
	
	void Awake (){
		player = GameObject.FindGameObjectWithTag ("Player");
		vida = player.GetComponent <vida> ();
		player2 = GameObject.FindGameObjectWithTag ("Player2");
		vidar = player2.GetComponent <vida2> ();
		playerAudio = GetComponent <AudioSource> ();
	}
	
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject == player){
			playerInRange = true;
		}
		if(other.gameObject == player2){
			playerInRange2 = true;
		}
	}
	
	
	void OnTriggerExit (Collider other){
		if(other.gameObject == player){
			playerInRange = false;
		}
		if(other.gameObject == player2){
			playerInRange2 = false;
		}
	}
	
	
	void Update (){
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		
		if(timer >= timeBetweenAttacks && playerInRange){
			Attack ();
		}
		if(timer2 >= timeBetweenAttacks && playerInRange2){
			Attack2 ();
		}
	}
	
	
	void Attack (){
		timer = 0f;
		if(vida.vidasobrando > 0){
			playerAudio.clip = linguicatiro;
			playerAudio.Play ();
			Instantiate(oldparr, transform.position, transform.rotation);
			vida.takedamage (attackDamage);
		}
	}

	void Attack2 (){
		timer2 = 0f;
		if(vidar.vidasobrando > 0){
			playerAudio.clip = linguicatiro;
			playerAudio.Play ();
			Instantiate(oldparr, transform.position, transform.rotation);
			vidar.takedamage (attackDamage);
		}
	}
}
