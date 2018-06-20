using UnityEngine;
using System.Collections;

public class farms : MonoBehaviour {
	pontuaçao points;

	void Start () {
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			points.fazendas++;
			Destroy (gameObject);
		}
	}

	void Update () {
	
	}
}
