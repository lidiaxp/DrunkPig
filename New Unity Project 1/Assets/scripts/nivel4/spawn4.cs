using UnityEngine;
using System.Collections;

public class spawn4 : MonoBehaviour {
	life4 health;       
	public GameObject enemy;                
	public float spawnTime = 0.5f;           
	public Transform[] spawnPoints;  
	bool pause = false;
	
	void Start (){
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		health = GetComponent<life4> ();
	}
	
	void Spawn (){
		if(Time.timeSinceLevelLoad >= 9){

			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		}
	}
}
