using UnityEngine;
using System.Collections;

public class movimentomal : MonoBehaviour {

	Transform player;
	NavMeshAgent nav;
	jacklife playerHealth;    
	
	void Awake () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		playerHealth = player.GetComponent <jacklife> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	void Update () {
		 if( playerHealth.vidasobrando > 0){
			nav.SetDestination (player.position);
		}else{
			nav.enabled = false;
		}
	}
}
