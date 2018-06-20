using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class movimentoinimigo9 : MonoBehaviour {
	public Image inicio;

	Transform player;
	NavMeshAgent nav;    

	void Awake () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}

	void Update () {
		if(!inicio.enabled){
			nav.SetDestination (player.position);
		}
	}
}
