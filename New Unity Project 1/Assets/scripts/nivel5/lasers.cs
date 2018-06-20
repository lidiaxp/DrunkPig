using UnityEngine;
using System.Collections;

public class lasers : MonoBehaviour {
	life5 life;
	GameObject terreno; 

	void Start () {
		life = FindObjectOfType (typeof(life5)) as life5;
		terreno = GameObject.FindGameObjectWithTag ("Terrain");
	}

	void Update () {
		transform.Translate(3f,0,0);	
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player" ){
			life.takedamage (70);
			Destroy (gameObject);
		}
		if(other.gameObject == terreno){
			Destroy (gameObject);
		}
	}
}
