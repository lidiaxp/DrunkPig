using UnityEngine;
using System.Collections;

public class redlgbt : MonoBehaviour { 
	GameObject jogador;
	GameObject inimigo;
	GameObject terreno; 
	GameObject jogador2;
	
	float timer;
	vida vida;
	
	void Awake () {
		jogador = GameObject.FindGameObjectWithTag ("Player");
		jogador2 = GameObject.FindGameObjectWithTag ("Player2");
		inimigo = GameObject.FindGameObjectWithTag ("Enemy");
		terreno = GameObject.FindGameObjectWithTag ("Terrain");
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject == terreno || other.gameObject == inimigo || other.gameObject == jogador || other.gameObject == jogador2){
			Destroy(gameObject);
		}
	}

	void OnTriggerExit (Collider other){

	}

	void Update () {
		transform.Translate(-20f * Time.deltaTime,0,0);
		Destroy(gameObject,3);
		if (Physics.Raycast (transform.position, transform.forward, 1)) {
			Destroy (gameObject);
		}
	}
}
