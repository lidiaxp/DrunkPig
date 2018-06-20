using UnityEngine;
using System.Collections;

public class frente : MonoBehaviour {
	pontuaçao points;

	void Start () {
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			points.fabricas++;
			Destroy (gameObject);
		}
	}

	void Update () {
	
	}
}
