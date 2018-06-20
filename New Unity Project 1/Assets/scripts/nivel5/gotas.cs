using UnityEngine;
using System.Collections;

public class gotas : MonoBehaviour {
	gotinp agua;
	GameObject terreno; 

	void Awake(){
		agua = FindObjectOfType (typeof(gotinp)) as gotinp;
		terreno = GameObject.FindGameObjectWithTag ("Terrain");
	}

	void Start () {
	}

	void Update () {
		transform.Translate(0,-0.8f,0);
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			Destroy (gameObject);
			agua.water++;
		}
		if(other.gameObject == terreno){
			Destroy (gameObject);
		}
	}
}
