using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnpedra : MonoBehaviour {
	public GameObject stone;    
	public float spawnTime = 0.06f;   
	public Image inicio;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update () {

	}

	void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (Random.Range(-1114f,428f), Random.Range(-0.9f,8f), 112f);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (stone, spawnPosition, spawnRotation);
		}
	}
}
