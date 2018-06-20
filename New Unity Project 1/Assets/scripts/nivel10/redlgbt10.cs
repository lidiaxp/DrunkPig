using UnityEngine;
using System.Collections;

public class redlgbt10 : MonoBehaviour {
	GameObject jogador;
	GameObject inimigo;
	GameObject terreno; 
	GameObject musician; 

	float timer;

	void Awake () {
		jogador = GameObject.FindGameObjectWithTag ("Player");
		inimigo = GameObject.FindGameObjectWithTag ("Enemy");
		terreno = GameObject.FindGameObjectWithTag ("Terrain");
		musician = GameObject.FindGameObjectWithTag ("Musician");
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject == jogador || other.gameObject == musician || other.gameObject == inimigo){
			Destroy(gameObject);
		}
	}

	void OnTriggerExit (Collider other){

	}

	void Update () {
		transform.Translate(100f * Time.deltaTime,0,0);
		Destroy(gameObject,3);
		if (Physics.Raycast (transform.position, transform.forward, 1)) {
			Destroy (gameObject);
		}
	}
}
