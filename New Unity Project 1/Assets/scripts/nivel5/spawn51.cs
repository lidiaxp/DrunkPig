using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawn51 : MonoBehaviour {     
	public GameObject enemy;    
	public float spawnTime = 0.5f;   
	public Image inicio;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update () {
		
	}

	void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (-45f, Random.Range(-4f,6f), Random.Range(-14f,14f));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (enemy, spawnPosition, spawnRotation);
		}
	}
}
