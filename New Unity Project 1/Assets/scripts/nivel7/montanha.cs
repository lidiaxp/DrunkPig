using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class montanha : MonoBehaviour {
	life7 life;

	void Start () {
		life = FindObjectOfType (typeof(life7)) as life7;
	}

	void Update () {
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player" ){
			Destroy (gameObject);
		}
	}
}
