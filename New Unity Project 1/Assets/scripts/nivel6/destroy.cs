using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	void Start () {
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			Destroy (gameObject);
		}
	}

	void Update () {
	
	}
}
