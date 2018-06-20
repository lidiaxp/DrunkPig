using UnityEngine;
using System.Collections;

public class mao : MonoBehaviour {

	life4 life4;
	GameObject player;
	GameObject terreno;

	void Start () {
		life4 = FindObjectOfType (typeof(life4)) as life4;
		player = GameObject.FindGameObjectWithTag ("Player");
		terreno = GameObject.FindGameObjectWithTag ("Terrain");
	}

	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject == player){
			life4.takedamage(50);
		}
		if(other.gameObject == terreno){
			Destroy (gameObject);
		}
	}
}
