using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class vidainimigo : MonoBehaviour {
	public int vidainicial = 9;
	public int vidasobrando;                            
	public int scoreValue = 1; 
	                        
	bool isDead;
	public bool senti = false;
	score ponto;
	score2 ponto2;
	AudioSource playerAudio; 
	criarinimigos criarinimigos;
                          	
	void Awake (){
		vidasobrando = vidainicial;
		ponto = FindObjectOfType (typeof(score)) as score;
		ponto2 = FindObjectOfType (typeof(score2)) as score2;
		playerAudio = GetComponent <AudioSource> ();
		criarinimigos = FindObjectOfType (typeof(criarinimigos)) as criarinimigos;
	}
	
	void Update (){
		
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Bala"){
			Death ();
		}
		if(other.gameObject.tag == "Bala2"){
			Death2 ();
		}
	}
	
	
	public void takedamage (int dor){
		senti = true;
		vidasobrando -= dor;
		if (isDead) {
			return;
		}
	}
	
	void Death (){
		vidasobrando = 0;
		isDead = true;
		GetComponent <NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		ponto.pontos += scoreValue;
		playerAudio.Play ();
		Destroy (gameObject,0.2f);
	}

	void Death2 (){
		vidasobrando = 0;
		isDead = true;
		GetComponent <NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		ponto2.pontos2 += scoreValue;
		playerAudio.Play ();
		Destroy (gameObject,0.2f);
	}
}
