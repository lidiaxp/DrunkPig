using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tospawn : MonoBehaviour {
	public jacklife playerHealth;       
	public GameObject enemy;                
	public float spawnTime = 4f;           
	public Transform[] spawnPoints;
	public Image inicio;

	bool pause = false;
	bool go;

	void Awake(){
		go = false;
	}

	void Start (){
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void update(){
		
	}
	
	void Spawn (){
		if(!inicio.enabled){
			if(playerHealth.vidasobrando <= 0f){
				return;
			}
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		}
	}
}
