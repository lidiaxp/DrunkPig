using UnityEngine;
using System.Collections;

public class destroil : MonoBehaviour {
	andar andar;
	
	void Start () {
		andar = GetComponent<andar>();
	}
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			andar.frente = andar.frente + 2;
			andar.pulo = andar.pulo + 0.1f;
			Destroy (gameObject);
		}
	}
	
	void Update () {
		
	}
}
