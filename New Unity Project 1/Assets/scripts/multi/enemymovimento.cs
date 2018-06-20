using UnityEngine;
using System.Collections;

public class enemymovimento : MonoBehaviour {

	Transform player;
	NavMeshAgent nav;
	vida playerHealth;      
	vidainimigo enemyHealth;    

	void Awake () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		playerHealth = player.GetComponent <vida> ();
		enemyHealth = GetComponent <vidainimigo> ();
		nav = GetComponent <NavMeshAgent> ();
	}

	void Update () {
		if (playerHealth.vidasobrando < 1) {
			nav.enabled = false;
		} else if(enemyHealth.vidasobrando < 1){
			nav.enabled = false;
		}else {
			nav.SetDestination (player.position);
		}
	}
}
