using UnityEngine;
using System.Collections;

public class criarinimigos : MonoBehaviour {
	public vida playerHealth;       
	public GameObject enemy;                
	public float spawnTime = 3f;           
	public Transform[] spawnPoints;  
	bool pause = false;
	
	void Start (){
			InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn (){
		if (playerHealth.vidasobrando <= 0f) {
			return;
		}
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}
