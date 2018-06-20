using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class carromovimento : MonoBehaviour {
	public Image mortecarro;
	public Image inicio;
	public Image fim;
	public Image teste;

	Transform chegada;
	Transform player;
	NavMeshAgent nav;    

	void Awake () {
		chegada = GameObject.FindGameObjectWithTag("Chegada").transform;
		nav = GetComponent <NavMeshAgent> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Chegada" && !fim.enabled){
			teste.enabled = true;
			mortecarro.enabled = true;
			Destroy (gameObject);
		}
	}

	void Update () {
		if(!inicio.enabled){
			nav.SetDestination (chegada.position);
		}
	}
}
