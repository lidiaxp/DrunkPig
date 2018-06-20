using UnityEngine;
using System.Collections;

public class enemymovimento2 : MonoBehaviour {
	Transform player2;
	NavMeshAgent nav;     
	vidainimigo enemyHealth;
	vida2 playerHealth2;      
	
	void Awake () {
		player2 = GameObject.FindGameObjectWithTag("Player2").transform;
		playerHealth2 = player2.GetComponent <vida2> ();
		enemyHealth = GetComponent <vidainimigo> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	void Update () {
		if (playerHealth2.vidasobrando < 1) {
			nav.enabled = false;
		} else if(enemyHealth.vidasobrando < 1){
			nav.enabled = false;
		}else {
			nav.SetDestination (player2.position);
		}
	}
}
