using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class criarinimigo9 : MonoBehaviour {
	public life9 playerHealth;       
	public GameObject enemy;                
	public float spawnTime = 0.6f;           
	public Transform[] spawnPoints;  
	public Image inicio;

	spawnmusician chefe;

	void Start (){
		chefe = FindObjectOfType (typeof(spawnmusician)) as spawnmusician;
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update(){
		if(chefe.chefao == 1){
			CancelInvoke ("Spawn");
			InvokeRepeating("Spawn", 2f, 2f);
			chefe.chefao = 0;
		}	
	}

	void Spawn (){
		if(!inicio.enabled){
			if (playerHealth.vidasobrando <= 0f) {
				return;
			}
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Quaternion spwanrotation = Quaternion.Euler (0,40,90);
			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spwanrotation);
		}
	}
}
