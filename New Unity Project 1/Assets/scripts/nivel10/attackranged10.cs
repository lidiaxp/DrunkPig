using UnityEngine;
using System.Collections;

public class attackranged10 : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;     
	public int attackDamage = 20; 
	public GameObject oldparr;
	public AudioClip linguicatiro;

	GameObject player;
	life10 jacklife; 
	bool playerInRange; 
	float timer;
	AudioSource playerAudio; 

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		jacklife = player.GetComponent <life10> ();
		playerAudio = GetComponent <AudioSource> ();
	}
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject == player ){
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
		if(jacklife.vidasobrando > 0){
			Instantiate (oldparr, transform.position,transform.rotation);
			playerAudio.clip = linguicatiro;
			playerAudio.Play ();
			Instantiate(oldparr, transform.position, transform.rotation);
			jacklife.takedamage (attackDamage);
		}
	}
}
