using UnityEngine;
using System.Collections;

public class pedra : MonoBehaviour {
	life8 life;

	void Start () {
		life = FindObjectOfType (typeof(life8)) as life8;
	}

	void Update () {
		transform.Translate(0,0,-14f);	
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			life.takedamage (150);
			Destroy (gameObject);
		}
		if(other.gameObject.tag == "Terrain"){
			Destroy (gameObject);
		}
	}
}
