using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class colher : MonoBehaviour {
	public GameObject one;

	BoxCollider box1;
	musica10 musica;
	colherspawn spoon;

	bool dentro;

	void Start () {
		box1 = one.GetComponent<BoxCollider> ();
		musica = FindObjectOfType (typeof(musica10)) as musica10;
		spoon = FindObjectOfType (typeof(colherspawn)) as colherspawn;
		dentro = false;
	}

	void OnTriggerEnter (Collider other){
		if (spoon.colheres >= 15) {
			if(other.gameObject.tag == "Player"){
				musica.musica = true;
				box1.isTrigger = false;
				transform.Translate (0, 0, -40 * Time.deltaTime);
				dentro = true;
			}
		} else {
			if(other.gameObject.tag == "Player"){
				spoon.morteconcha1 = true;
			}
		}
	}

	void Update () {
		if (dentro) {
			if(transform.position.y > -60){
				spoon.teste1 = true;
			}
			if(transform.position.y > 20){
				Destroy (gameObject);
			}
			dentro = false;
		}
	}
}