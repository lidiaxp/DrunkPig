using UnityEngine;
using System.Collections;

public class aviao : MonoBehaviour {
	life7 life;

	void Start () {
		life = FindObjectOfType (typeof(life7)) as life7;
	}

	void Update () {
		transform.Translate(3f,0,0);	
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			Destroy (gameObject);
		}
		if(other.gameObject.tag == "Terrain"){
			Destroy (gameObject);
		}
	}
}
